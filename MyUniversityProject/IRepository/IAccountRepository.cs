
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.Pagination;
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
        Task<UserInfo> GetUser(int id);
        Task<string> DeleteUser(int userId);
        Task<string> UpdateAsync(UserInfo user);
        Task<string> UpdatePassword(string Email, ChangePassword password);
        Task<int> UserInfoId(string Email);
        Task<IndexUserViewModel> GetUsers(UserFilterViewModel indexUser, int page);
        IEnumerable<UserInfo> GetSortUser(IEnumerable<UserInfo> list, string SortItem);
        Task<IEnumerable<UserInfo>> GetSearchingUser(UserFilterViewModel indexUser);

    }
}
