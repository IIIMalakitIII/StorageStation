using Microsoft.AspNetCore.Mvc.Rendering;
using MyUniversityProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IStandartRepository
    {
        Task<List<SelectListItem>> GetStandartsCellModelAsync();
        Task<IEnumerable<Standard>> GetStandartsAsync(string searching, string sortOrder);
        Task<Standard> GetStandartAsync(int id);
        Task<string> SaveAsync();
        Task<string> DeleteStandartAsync(int id);
        Task<string> CreateStandartAsync(Standard standard);
    }
}
