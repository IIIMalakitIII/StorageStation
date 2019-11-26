using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DataContext dataContext;

        public AccountRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task Registration(RegisterModel model)
        {
            model.Password = Cryptography.Encrypt(model.Password);
            UserInfo user = new UserInfo()
            {
                UserInfoId = 0,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                Password = model.Password,
                Email = model.Email,
                Role = "User"
            };
            await dataContext.UserInfos.AddAsync(user);
        }

        public async Task<UserInfo> Login(LoginModel model) =>
            await dataContext.UserInfos.FirstOrDefaultAsync(o => o.Email == model.Email && o.Password == Cryptography.Encrypt(model.Password));

        public bool UserExists(string Email) =>
            dataContext.UserInfos.Any(o => o.Email == Email);

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
            

        public async Task<UserInfo> GetUser(string Email)=>
            await dataContext.UserInfos.FirstOrDefaultAsync(o => o.Email == Email);

        public async Task<string> UpdateAsync(UserInfo user)
        {
            dataContext.UserInfos.Update(user);
            var result = await SaveAsync();
            return result;
        }

        public async Task<string> UpdatePassword(string Email, ChangePassword password)
        {
            var user = await GetUser(Email);
            if (user != null && user.Password == Cryptography.Encrypt(password.OldPassword))
            {
                user.Password = Cryptography.Encrypt(password.NewPassword);
                var result = await UpdateAsync(user);
                return result;
            }
            return null;
        }

        public async Task<int> UserInfoId(string Email)
        {
            var user = await GetUser(Email);
            return user.UserInfoId;
        }

    }
}
