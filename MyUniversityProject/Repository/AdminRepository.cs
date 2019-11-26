using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DataContext dataContext;

        public AdminRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Employee> Login(LoginModel model) =>
            await dataContext.Employee.FirstOrDefaultAsync(o => o.Email == model.Email && o.Password == Cryptography.Encrypt(model.Password));


        public async Task<string> UpdateEmployee(Employee employee)
        {
            dataContext.Employee.Update(employee);
            var result = await SaveAsync();
            return result;
        }

        public async Task<string> UpdatePassword(string Email, ChangePassword password)
        {
            var employee = await GetEpmloyee(Email);
            if (employee != null)
            {
                employee.Password = Cryptography.Encrypt(password.NewPassword);
                var result = await UpdateEmployee(employee);
                return result;
            }
            return null;
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
                return "Failed to save, maybe there is an error";
            }
        }

        public async Task<Employee> GetEpmloyee(string Email) =>
            await dataContext.Employee.FirstOrDefaultAsync(o => o.Email == Email);

    }
}
