using MyUniversityProject.Models;
using MyUniversityProject.Models.ReservationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Serviece
{
    public class SelectionAlgorithm
    {

        //List<Luggage> luggage = new List<Luggage>();
        //List<Cell> cells = new List<Cell>();
        static public int CountTrue(bool[] arr)//количество багажей которіе поместятся в єту ячейку 
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    res++;
                }
            }
            return res;
        }

        static public List<Cell> Sort(List<Cell> boxes)
        {
            Cell temp;
            for (int i = 0; i < boxes.Count - 1; i++)
            {
                for (int j = i + 1; j < boxes.Count; j++)
                {
                    if (boxes[i].Standard.Price > boxes[j].Standard.Price)
                    {
                        temp = boxes[i];
                        boxes[i] = boxes[j];
                        boxes[j] = temp;
                    }
                }
            }
            return boxes;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i">число которое переводимот 0 до 15 всего 16</param>
        /// <param name="p">количество бит/кол-во багажа </param>
        /// <returns></returns>
        static public string GetMask(int i, int p)//двоичный код (перевод число из 10 системы в двоичную )  //что бы понять 0010 этопример маски этозначит первый второй и 4 элемент мы кладем вертикально
        {
            string mask = ""; //двоичная запись числа
            int h = i;
            while (h != 0)
            {
                mask = h % 2 + mask;
                h /= 2;
            }
            int s = mask.Length;
            for (int k = 0; k < p - s; k++)
            {
                mask = 0 + mask;
            }
            return mask;

        }

        static public List<Luggage> SortLengths(List<Luggage> bags) // высота делает максимальная, длина и ширина сортирует багаж по их характеристиком 
        {
            for (int i = 0; i < bags.Count; i++)
            {
                if (bags[i].Width > bags[i].Height)
                {
                    int temp = bags[i].Width;
                    bags[i].Width = bags[i].Height;
                    bags[i].Height = temp;
                }
                if (bags[i].Length > bags[i].Height)
                {
                    int temp = bags[i].Length;
                    bags[i].Length = bags[i].Height;
                    bags[i].Height = temp;
                }
                if (bags[i].Width > bags[i].Length)
                {
                    int temp = bags[i].Width;
                    bags[i].Width = bags[i].Length;
                    bags[i].Length = temp;
                }
            }
            return bags;
        }


        static public int[] Algo(List<Cell> boxes, List<Luggage> bags)//максимум 5 багажей
        {
            boxes = Sort(boxes);
            int res = -1;//номер ячейки 
            int Max = 0;//максимальное кол-во багажа которое мы всунули
            bool[] resarr = new bool[bags.Count]; //массив в котором отмечаем берем тот или иной багаж
            for (int j = 0; j < resarr.Length; j++) //каждому багажу присваивает фолсс изначально мы ничего не ббьерем 
            {
                resarr[j] = false;
            }
            for (int i = 0; i < boxes.Count; i++) //перебираем все ячейки
            {
                bags = SortLengths(bags);
                bool[] arr0 = new bool[bags.Count]; //массив в котором проверяем проход ли он по высоте 
                for (int j = 0; j < arr0.Length; j++)
                {
                    arr0[j] = true;//изначально всем тру
                }


                for (int j = 0; j < bags.Count; j++)
                {
                    if (bags[j].Height > boxes[i].Height)//если высота коробки больше высоты ячейки то  мы меняйм места длину и высоту 
                    {
                        int temp = bags[j].Length;
                        bags[j].Length = bags[j].Height;
                        bags[j].Height = temp;
                        if (bags[j].Height > boxes[i].Height)// если высота которая была поменятая с местами с длиной опять не подошла то меняем высоту с шириной 
                        {
                            int temp1 = bags[j].Width;
                            bags[j].Width = bags[j].Height;
                            bags[j].Height = temp1;
                            if (bags[j].Height > boxes[i].Height)// если высота котора опять была поменятая не подошла то багаж масивов не подешел
                            {
                                arr0[j] = false;
                            }
                        }
                    }
                }

                for (int j = 0; j < Convert.ToInt32(Math.Pow(2, bags.Count)); j++)// количество вариантов как мы можем расположить багаж вертикально или горизонтально 
                {
                    string mask = GetMask(j, bags.Count);// получили маску вид комбинацию

                    for (int k = 0; k < mask.Length; k++) // если стоит еденичка то мы меняем ширину с длиной, что бы все чемоданы были в одной проекции
                    {
                        if (mask[k] == '1' && arr0[k] == true)
                        {
                            int temp = bags[k].Width;
                            bags[k].Width = bags[k].Length;
                            bags[k].Length = temp;
                        }
                    }
                    bool[] arr1 = new bool[bags.Count]; // массив который отвечает берем мы вешь или нет именно для маски 
                    for (int k = 0; k < arr1.Length; k++)
                    {
                        arr1[k] = false;
                    }

                    int w = 0;//сумма веса
                    for (int k = 0; k < bags.Count; k++) // по очереди перебираем каждый ебаный багаж
                    {
                        if (arr0[k] == true) //багаж влазит по высоте берем 
                        {
                            if (w + bags[k].Width <= boxes[i].Width)//если по весу проходит то дальше идем
                            {
                                if (k == 0)//если этот багаж летит первым в приоритетный 
                                {
                                    if (bags[k].Length <= boxes[i].Length && bags[k].Width <= boxes[i].Width) // влезит ли он по ширине и длине  в ячейку
                                    {
                                        arr1[k] = true;// если да то мы меняем массив который отвечает берем или не берем
                                    }
                                }
                                if (k == 1) // берем ли второй багаж 
                                {
                                    bool temp = true; // возьмем ли мы этот багаж или нет 
                                    if (arr1[0] == true) // проверыяет взяли мы первый чемодан 
                                    {
                                        if (bags[k].Length + bags[0].Length > boxes[i].Length)// проверяем не пересекутся ли они по длине/ то бишь они привысят длину ячейки то не берем багаж
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (bags[k].Length > boxes[i].Length || bags[k].Length > boxes[i].Length)// если мы не взяли первый то проверит влезит ли он по длине и ширине 
                                    {
                                        temp = false;
                                    }
                                    arr1[k] = temp;
                                }
                                if (k == 2)//  делает то же самое, 
                                {
                                    bool temp = true;
                                    if (arr1[1] == true) //пересечется ли он с воторым 
                                    {
                                        if (bags[k].Length + bags[1].Length > boxes[i].Length && bags[k].Width + bags[1].Width > boxes[i].Width)
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (arr1[0] == true)//с первым 
                                    {
                                        if (bags[k].Width + bags[1].Width > boxes[i].Width)
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (bags[k].Length > boxes[i].Length || bags[k].Length > boxes[i].Length) // влезет ли он вообще 
                                    {
                                        temp = false;
                                    }
                                    arr1[k] = temp;
                                }
                                if (k == 3)//то же самое 
                                {
                                    bool temp = true;
                                    if (arr1[0] == true)
                                    {
                                        if (bags[k].Length + bags[0].Length > boxes[i].Length && bags[k].Width + bags[0].Width > boxes[i].Width)
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (arr1[1] == true)
                                    {
                                        if (bags[k].Width + bags[1].Width > boxes[i].Width)
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (arr1[2] == true)
                                    {
                                        if (bags[k].Length + bags[2].Length > boxes[i].Length)
                                        {
                                            temp = false;
                                        }
                                    }
                                    if (bags[k].Length > boxes[i].Length || bags[k].Length > boxes[i].Length)
                                    {
                                        temp = false;
                                    }
                                    arr1[k] = temp;
                                }
                                if (arr1[k]) // сумируем веса 
                                {
                                    w += bags[k].Capacity;
                                }
                            }
                        }
                    }
                    if (CountTrue(arr1) > Max) //если кол-во вхождений багажа больше чем в максимольном случае
                    {
                        res = boxes[i].CellId; // индекс ячейки
                        Max = CountTrue(arr1); //количество багажа которое мы можем взять
                        resarr = arr1;//массив показует какие богажи мы берем а какие неты
                    }
                }
            }
            int[] result = new int[1];//массив в котором хранится ответ 
            result[0] = res;//номер айди ящика в который мы должны вложить 
            for (int i = 0; i < resarr.Length; i++)
            {
                if (!resarr[i])
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = i;
                }
            }
            return result;
        }

    }
}

