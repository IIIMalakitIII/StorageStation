using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.ErrorViewModel;
using MyUniversityProject.Models.FilterModel;
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

        /*public async Task<IndexCellViewModel> GetCellsAsync(int storageId, int page)
        {
            IQueryable<Cell> cells = dataContext.Cells.Where(o => o.StorageId == storageId);
            var count = cells.Count();
            var skipCells = cells.Skip((page - 1) * 20).Take(20).ToList();
            
            var list = await Task.Run(()=> ListCells(skipCells));
            PageViewModel pageViewModel = new PageViewModel(count, page, 20);
            IndexCellViewModel viewModel = new IndexCellViewModel
            {
                PageViewModel = pageViewModel,
                Cells = list
            };
            return viewModel;
        }
        */


        public async Task<string> CreateStorageAsync(Storage storage)
        {
            await dataContext.Storages.AddAsync(storage);
            return await SaveAsync();
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

        public List<Storage> GetStoragesCell()
        {
            var Storage = dataContext.Storages
                .Include(blog => blog.Cells)
                .ToList();

            return Storage;
        }

      
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

        public async Task<IndexCellViewModel> GetCellsAsync(CellFilterViewModel cellFilter, int page)
        {
            if (cellFilter == null)
            {
                cellFilter = new CellFilterViewModel();
                cellFilter.SortItem = "";
                cellFilter.SearchValue = "";
                cellFilter.SearchFilter = "";
            }
            cellFilter.SearchValue = cellFilter.SearchValue == null ? "Any" : cellFilter.SearchValue;
            cellFilter.SearchFilter = cellFilter.SearchFilter == null ? "" : cellFilter.SearchFilter;
            cellFilter.SortItem = cellFilter.SortItem == null ? "" : cellFilter.SortItem;

            IEnumerable<Cell> cells = OrderByCell(await FilterSearch(cellFilter), cellFilter.SortItem);
            
            var count = cells.Count();
            var skipCells = cells.Skip((page - 1) * 20).Take(20).ToList();

            var list = ListCells(skipCells);
            PageViewModel pageViewModel = new PageViewModel(count, page, 20);
            IndexCellViewModel viewModel = new IndexCellViewModel
            {
                PageViewModel = pageViewModel,
                Cells = list,
                CellFilterViewModel = cellFilter
            };
            return viewModel;
        }

        public async Task<IEnumerable<Cell>> FilterSearch(CellFilterViewModel cellFilter)
        {
            IQueryable<Cell> list = dataContext.Cells
                .AsNoTracking()
                .Include(x => x.Standard)
                .Where(x => x.StorageId == cellFilter.StorageId);

            if(cellFilter.MaxWidth ==0 && cellFilter.MinWidth != 0)
            {
                list = list.Where(x => x.Width >= cellFilter.MinWidth);
            }
            else if(cellFilter.MaxWidth != 0 && cellFilter.MinWidth != 0)
            {
                list = list.Where(x => x.Width >= cellFilter.MinWidth && x.Width <= cellFilter.MaxWidth);
            }

            if (cellFilter.MaxHeight == 0 && cellFilter.MinHeight != 0)
            {
                list = list.Where(x => x.Height >= cellFilter.MinHeight);
            }
            else if (cellFilter.MaxHeight != 0 && cellFilter.MinHeight != 0)
            {
                list = list.Where(x => x.Height >= cellFilter.MinHeight && x.Height <= cellFilter.MaxHeight);
            }

            if (cellFilter.MaxLength == 0 && cellFilter.MinLength != 0)
            {
                list = list.Where(x => x.Length >= cellFilter.MinLength);
            }
            else if (cellFilter.MaxLength != 0 && cellFilter.MinLength != 0)
            {
                list = list.Where(x => x.Length >= cellFilter.MinLength && x.Length <= cellFilter.MaxLength);
            }

            if (cellFilter.MaxCapacity == 0 && cellFilter.MinCapacity != 0)
            {
                list = list.Where(x => x.Capacity >= cellFilter.MinCapacity);
            }
            else if (cellFilter.MaxCapacity != 0 && cellFilter.MinCapacity != 0)
            {
                list = list.Where(x => x.Capacity >= cellFilter.MinCapacity && x.Capacity <= cellFilter.MaxCapacity);
            }

            switch (cellFilter.SearchValue)
            {
                case "Width":
                    return await list
                        .Where(x => x.Width.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Height":
                    return await list
                        .Where(x => x.Height.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Length":
                    return await list
                        .Where(x => x.Length.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Capacity":
                    return await list
                        .Where(x => x.Capacity.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Standart_Id":
                    return await list
                        .Where(x => x.StandardId.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Standart_Price":
                    return await list
                        .Where(x => x.Standard.Price.ToString().Contains(cellFilter.SearchFilter))
                        .ToListAsync();
                case "Status":
                    bool statusFilter =
                        cellFilter.SearchFilter == "Active" ||
                        cellFilter.SearchFilter == "active" ||
                        cellFilter.SearchFilter == "True" ||
                        cellFilter.SearchFilter == "true" ||
                        cellFilter.SearchFilter == "1";

                    return await list
                        .Where(x => x.Status == statusFilter)
                        .ToListAsync();
                default:
                    return await list
                        .Where(x => 
                             x.Standard.Price.ToString().Contains(cellFilter.SearchFilter) ||
                             x.StandardId.ToString().Contains(cellFilter.SearchFilter) ||
                             x.Capacity.ToString().Contains(cellFilter.SearchFilter) ||
                             x.Height.ToString().Contains(cellFilter.SearchFilter) ||
                             x.Length.ToString().Contains(cellFilter.SearchFilter) ||
                             x.Width.ToString().Contains(cellFilter.SearchFilter) ||
                             x.Status.ToString().Contains(cellFilter.SearchFilter)
                            )
                        .ToListAsync();
            }
        }
        public IEnumerable<Cell> OrderByCell(IEnumerable<Cell> cells, string sortItem)
        {
            switch (sortItem)
            {
                case "Width_ASC":
                    return cells.OrderBy(x => x.Width);
                case "Width_DESC":
                    return cells.OrderByDescending(x => x.Width);
                case "Height_ASC":
                    return cells.OrderBy(x => x.Height);
                case "Height_DESC":
                    return cells.OrderByDescending(x => x.Height);
                case "Capacity_ASC":
                    return cells.OrderBy(x => x.Capacity);
                case "Capacity_DESC":
                    return cells.OrderByDescending(x => x.Capacity);
                case "Length_ASC":
                    return cells.OrderBy(x => x.Length);
                case "Length_DESC":
                    return cells.OrderByDescending(x => x.Length);
                case "Price_ASC":
                    return cells.OrderBy(x => x.Standard.Price);
                case "Price_DESC":
                    return cells.OrderByDescending(x => x.Standard.Price);
                default:
                    return cells.OrderBy(x => x.CellId); ;
            }
        }
    }
}
