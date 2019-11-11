
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
        Task<bool> SaveAsync();
        bool UserExists(string Email);
        Task<UserInfo> GetUser(string Email);
        void Update(UserInfo user);
        Task<bool> Check(string Email, UserInfo userInfo);
        Task<UserInfo> UpdatePassword(string Email, ChangePassword password);
    }
}
