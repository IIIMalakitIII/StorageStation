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


        public void UpdateEmployee(Employee employee)
        {
            dataContext.Employee.Update(employee);
        }

        public async Task<Employee> UpdatePassword(string Email, ChangePassword password)
        {
            var employee = await GetEpmloyee(Email);
            if (employee != null)
            {
                employee.Password = Cryptography.Encrypt(password.NewPassword);
                UpdateEmployee(employee);
                return employee;
            }
            return null;
        }

        public async Task<bool> SaveAsync() =>
            await dataContext.SaveChangesAsync() > 0;

        public async Task<Employee> GetEpmloyee(string Email) =>
            await dataContext.Employee.FirstOrDefaultAsync(o => o.Email == Email);

        public async Task<bool> Check(string Email, Employee employee)
        {
            var employeeFind = await GetEpmloyee(Email);
            return employeeFind.Equals(employee);
        }
    }
}
