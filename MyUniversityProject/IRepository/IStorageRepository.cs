﻿using MyUniversityProject.Models;
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
        Task<IEnumerable<Cell>> GetCellsAsync(int storageId);
        Task<IndexViewModel> GetCellsAsync(int storageId, int page);
        List<List<Cell>> ListCells(List<Cell> skipCells);
        List<Storage> GetStoragesCell();
        Task<Storage> GetStorageInfoAsync(int id);
        Task<bool> Check(Storage storage);
        Task<bool> Update(Storage storage);
        Task<List<Cell>> GetAllStorageInfoAsync(int storageId);
        Task SaveAsync();


    }
}