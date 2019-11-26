
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.IRepository
{
    public interface IAccountRepository
    {
        Task Registration(RegisterModel model);
        Task<UserInfo> Login(LoginModel model);
        Task<string> SaveAsync();
        bool UserExists(string Email);
        Task<UserInfo> GetUser(string Email);
        Task<string> UpdateAsync(UserInfo user);
        Task<string> UpdatePassword(string Email, ChangePassword password);
        Task<int> UserInfoId(string Email);

    }
}
