using MyUniversityProject.Models;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IStorageRepository
    {
        Task<IEnumerable<Storage>> GetAllStorageAsync(string searching, string sortOrder);
        //Task<IEnumerable<Cell>> GetCellsAsync(int storageId);
        //Task<IndexCellViewModel> GetCellsAsync(int storageId, int page);
        List<List<Cell>> ListCells(List<Cell> skipCells);
        List<Storage> GetStoragesCell();
        Task<Storage> GetStorageInfoAsync(int id);
        //Task<bool> Update(Storage storage);
        Task<string> Update(Storage storage);
        Task<IEnumerable<Cell>> GetAllStorageInfoAsync(int storageId);
        IEnumerable<Cell> OrderByCell(IEnumerable<Cell> cells, string sortItem);
        Task<IEnumerable<Cell>> FilterSearch(CellFilterViewModel cellFilter);
        Task<IndexCellViewModel> GetCellsAsync(CellFilterViewModel cellFilter, int page);
        Task<string> CreateStorageAsync(Storage storage);
        Task<string> SaveAsync();
    }
}
