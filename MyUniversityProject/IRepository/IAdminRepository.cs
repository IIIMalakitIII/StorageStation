using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.StorageViewModel;
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
        SqlViewModel DashBoard(SqlViewModel sqlView);
        Task<IEnumerable<Employee>> GetAdmins(string sortOrder, string searching);
        Task<string> CreateAdmins(Employee employee);
        Task<string> UpdateAdmin(Employee employee);
        Task<Employee> GetEpmloyee(int Id);
        Task<string> DeleteAdmin(int employeeId);
    }
}
