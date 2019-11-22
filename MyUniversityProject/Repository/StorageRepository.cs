using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.ErrorViewModel;
using MyUniversityProject.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class StorageRepository : IStorageRepository
    {
        private readonly DataContext dataContext;

        public StorageRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        //public async Task<IEnumerable<Storage>> GetAllStorageAsync(string searching) =>
        //    await dataContext.Storages.Where(o => o.Location.Contains(searching)).ToListAsync();

        public async Task<IEnumerable<Storage>> GetAllStorageAsync(string searching, string sortOrder)
        {
            switch (sortOrder)
            {
                case "status":
                    return await dataContext.Storages.Where(o => o.Location.Contains(searching))
                        .OrderByDescending(o => o.Status).ToListAsync();
                case "Location":
                    return await dataContext.Storages.Where(o => o.Location.Contains(searching))
                        .OrderBy(o=>o.Location).ToListAsync();
                case "location":
                    return await dataContext.Storages.Where(o => o.Location.Contains(searching))
                        .OrderByDescending(o => o.Location).ToListAsync();
                default:
                    return await dataContext.Storages.Where(o => o.Location.Contains(searching))
                        .OrderBy(o => o.Status).ToListAsync();
            }

        }

        public async Task<Storage> GetStorageInfoAsync(int id) =>
            await dataContext.Storages.AsNoTracking()
            .Where(o => o.StorageId == id)
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<Cell>> GetAllStorageInfoAsync(int storageId) =>
            await dataContext.Cells
                .AsNoTracking()
                .Include(o => o.Reservations)
                .Where(x => x.StorageId == storageId && x.Reservations.Any(r => r.Status))
                .ToListAsync();

        public async Task<IEnumerable<Cell>> GetCellsAsync(int storageId) =>
            await dataContext.Cells.Where(o => o.StorageId == storageId).ToListAsync();

        public async Task<IndexCellModel> GetCellsAsync(int storageId, int page)
        {
            IQueryable<Cell> cells = dataContext.Cells.Where(o => o.StorageId == storageId);
            var count = cells.Count();
            var skipCells = cells.Skip((page - 1) * 20).Take(20).ToList();
            
            var list = await Task.Run(()=> ListCells(skipCells));
            PageViewModel pageViewModel = new PageViewModel(count, page, 20);
            IndexCellModel viewModel = new IndexCellModel
            {
                PageViewModel = pageViewModel,
                Cells = list
            };
            return viewModel;
        }

        public List<List<Cell>> ListCells(List<Cell> skipCells)
        {
            List<List<Cell>> list = new List<List<Cell>>();
            int index = 0;
            for (int i = 0; i < Convert.ToInt32(skipCells.Count() / 5)+1; i++)
            {
                List<Cell> listcell = new List<Cell>();

                for (int j = index; j < skipCells.Count(); j++)
                {

                    listcell.Add(skipCells[j]);
                    if (listcell.Count== 5)
                    {
                        index = j+1;
                        break;
                    }
                }
                list.Add(listcell);
            }
            return list;
        }
        /*
        public async Task SaveAsync()
        {
            try
            {
                await dataContext.SaveChangesAsync();
            }
            catch
            {
                throw new Exception("We are sorry. Your operation conflicted with another operation in database. It has been cancelled.");
            }
        }
        */

        public List<Storage> GetStoragesCell()
        {
            var Storage = dataContext.Storages
                .Include(blog => blog.Cells)
                .ToList();

            return Storage;
        }

        /*
        public async Task<bool> Update(Storage storage)
        {

            var oldStorage = await GetStorageInfoAsync(storage.StorageId);
            if (oldStorage.Status == storage.Status || storage.Status)
            {
                dataContext.Storages.Update(storage);
                return true;
            }
            else
            {
                var listOfCells = await GetAllStorageInfoAsync(storage.StorageId);
                if (listOfCells == null)
                {
                    dataContext.Storages.Update(storage);
                    return true;
                }
                else
                {
                    foreach (var cell in listOfCells)
                    {
                        if (cell.Reservations.Count > 0)
                        {
                            return false;
                        }
                    }
                }
                dataContext.Storages.Update(storage);
                return true;
            }
          
        }*/

        public async Task<string> SaveAsync()
        {
            try
            {
                await dataContext.SaveChangesAsync();
                return null;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> Update(Storage storage)
        {
            var listOfCells = await GetAllStorageInfoAsync(storage.StorageId);
            if(listOfCells.Count() > 0 && !storage.Status)
            {
                return "It is impossible to close the station storage, while there is existing reservation"; 
            }
            dataContext.Update(storage);
            return await SaveAsync();
        }

        public async Task<bool> Check(Storage storage)
        {
            Storage storageFind = await GetStorageInfoAsync(storage.StorageId);
            return storageFind == storage;
        }
    }
}
