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
        Task<string> UpdateEmployee(Employee employee);
        Task<string> UpdatePassword(string Email, ChangePassword password);
        Task<string> SaveAsync();
        Task<Employee> GetEpmloyee(string Email);
        //string DashBoard(string sql);
        Task<string> DashBoard(string sql);
    }
}
