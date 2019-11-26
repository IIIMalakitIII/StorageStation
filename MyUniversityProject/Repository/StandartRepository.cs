using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.StorageViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class StandartRepository : IStandartRepository
    {
        private readonly DataContext dataContext;

        public StandartRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<List<SelectListItem>> GetStandartsCellModelAsync()
        {
            return await dataContext.Standards
                .AsNoTracking()
                .Select(x => new SelectListItem
                {
                    Text = x.StandardId.ToString(),
                    Value = x.StandardId.ToString()
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<Standard>> GetStandartsAsync(string searching, string sortOrder)
        {
            var list = await dataContext.Standards.Where(o =>
            o.MinVolume.ToString().Contains(searching) ||
            o.MaxVolume.ToString().Contains(searching) ||
            o.Price.ToString().Contains(searching) ||
            o.StandardId.ToString().Contains(searching)).ToListAsync();
            switch (sortOrder)
            {
                case "minVolume":
                    return list.OrderByDescending(o => o.MinVolume);
                case "MaxVolume":
                    return list.OrderBy(o => o.MaxVolume);
                case "maxVolume":
                    return list.OrderByDescending(o => o.MaxVolume);
                case "Price":
                    return list.OrderBy(o => o.Price);
                case "price":
                    return list.OrderByDescending(o => o.Price);
                default:
                    return list.OrderBy(o => o.MinVolume);
            }
        }

        public async Task<Standard> GetStandartAsync(int id) =>
            await dataContext.Standards
                .AsNoTracking()
                .Include(x =>x.Cells)
                .Where(x=>x.StandardId==id)
                .FirstOrDefaultAsync();

        public async Task<string> DeleteStandartAsync(int id)
        {
            var standart = await GetStandartAsync(id);
            if (standart == null)
            {
                return "Something else";
            }

            if(standart.Cells.Any())
                return "You cannot delete the standart, while cell are use it";

            dataContext.Standards.Remove(standart);
            return await SaveAsync();
        }

        public async Task<string> SaveAsync()
        {
            try
            {
                await dataContext.SaveChangesAsync();
                return null;
            }
            catch
            {
                return "Sorry at moment save something else... try another time";
            }
        }

        public async Task<string> CreateStandartAsync(Standard standard)
        {
            dataContext.Standards.Add(standard);
            return await SaveAsync();
        }

        public async Task<string> UpdateStandartAsync(Standard standard)
        {
            var standardOld = await GetStandartAsync(standard.StandardId);
            if (standardOld == null)
            {
                return "Sorry, something else";
            }

            dataContext.Standards.Update(standard);
            return await SaveAsync();
        }

        public async Task<string> ChangeStandard(ChangeAllViewModel change)
        {
            var list = await dataContext.Cells.AsNoTracking().Where(x => x.StandardId == change.OldId).ToListAsync();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].StandardId = change.NewId;
                dataContext.Cells.Update(list[i]);
            }
            return await SaveAsync();
        }
    }
}
