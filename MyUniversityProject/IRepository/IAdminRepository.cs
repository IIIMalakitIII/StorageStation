using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IAdminRepository
    {
        Task<Employee> Login(LoginModel model);
        void UpdateEmployee(Employee employee);
        Task<Employee> UpdatePassword(string Email, ChangePassword password);
        Task<bool> SaveAsync();
        Task<Employee> GetEpmloyee(string Email);
        Task<bool> Check(string Email, Employee employee);
    }
}
