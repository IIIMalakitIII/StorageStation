using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.FilterModel;
using MyUniversityProject.Models.Pagination;
using System.Collections.Generic;
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
        public async Task<UserInfo> GetUser(int id) =>
            await dataContext.UserInfos.FirstOrDefaultAsync(o => o.UserInfoId == id);

        public async Task<string> UpdateAsync(UserInfo user)
        {
            if(dataContext.UserInfos.Any(x => x.UserInfoId == user.UserInfoId))
            {
                dataContext.UserInfos.Update(user);
                var result = await SaveAsync();
                return result;
            }
            return $"Something wrong, can't find user with this Id: {user.UserInfoId}";
        }

        public async Task<string> DeleteUser(int userId)
        {
            var reserve = await GetUser(userId);

            if (reserve == null)
            {
                return $"Did not find a user by this id = {userId}";
            }
            dataContext.Remove(reserve);
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

        public async Task<IndexUserViewModel> GetUsers(UserFilterViewModel indexUser, int page)
        {
            if (indexUser == null)
            {
                return new IndexUserViewModel()
                {
                    PageViewModel = new PageViewModel(0, 1, 3),
                    UserInfo = new List<UserInfo>(),
                    UserFilterViewModel = indexUser
                };
            }
            indexUser.SearchValue = indexUser.SearchValue == null ? "Any" : indexUser.SearchValue;
            indexUser.SearchFilter = indexUser.SearchFilter == null ? "" : indexUser.SearchFilter;
            indexUser.SortItem = indexUser.SortItem == null ? "" : indexUser.SortItem;

            IEnumerable<UserInfo> item = new List<UserInfo>();
            item =  GetSortUser(await GetSearchingUser(indexUser), indexUser.SortItem);

            var count = item.Count();
            var skipCells = item.Skip((page - 1) * 3).Take(3).ToList();
            if (skipCells.Count == 0 && page != 1)
            {
                skipCells = item.Skip((page - 2) * 3).Take(3).ToList();
                page -= 1;
            }

            PageViewModel pageViewModel = new PageViewModel(count, page, 3);
            IndexUserViewModel viewModel = new IndexUserViewModel
            {
                PageViewModel = pageViewModel,
                UserInfo = skipCells,
                UserFilterViewModel = indexUser
            };
            return viewModel;
        }


        public async Task<IEnumerable<UserInfo>> GetSearchingUser(UserFilterViewModel indexUser)
        {

            IQueryable<UserInfo> list = dataContext.UserInfos
                    .AsNoTracking()
                    .Include(x => x.Reservations);


            if (indexUser.MaxId == 0 && indexUser.MinId != 0)
            {
                list = list.Where(x => x.UserInfoId >= indexUser.MinId);
            }
            else if (indexUser.MaxId != 0 && indexUser.MinId != 0)
            {
                list = list.Where(x => x.UserInfoId >= indexUser.MinId && x.UserInfoId <= indexUser.MaxId);
            }


            switch (indexUser.SearchValue)
            {
                case "PassportId":
                    return await list.Where(x => x.PassportId.Contains(indexUser.SearchFilter)).ToListAsync();
                case "PhoneNumber":
                    return await list.Where(x => x.PhoneNumber.Contains(indexUser.SearchFilter)).ToListAsync();
                case "LastName":
                    return await list.Where(x => x.LastName.Contains(indexUser.SearchFilter)).ToListAsync();
                case "FirstName":
                    return await list.Where(x => x.FirstName.Contains(indexUser.SearchFilter)).ToListAsync();
                case "Address":
                    return await list.Where(x => x.Address.Contains(indexUser.SearchFilter)).ToListAsync();
                case "Email":
                    return await list.Where(x => x.Email.Contains(indexUser.SearchFilter)).ToListAsync();
                case "UserId":
                    return await list.Where(x => x.UserInfoId.ToString().Contains(indexUser.SearchFilter)).ToListAsync();
                case "ReserveId":
                    return await list.Where(x => 
                    x.Reservations.Any(o=> 
                        o.ReservationId.ToString().Contains(indexUser.SearchFilter)))
                        .ToListAsync();
                default:
                    return await list
                        .Where(x =>
                        x.PassportId.Contains(indexUser.SearchFilter) ||
                        x.PhoneNumber.Contains(indexUser.SearchFilter) ||
                        x.LastName.Contains(indexUser.SearchFilter) ||
                        x.FirstName.Contains(indexUser.SearchFilter) ||
                        x.Address.Contains(indexUser.SearchFilter) ||
                        x.Email.Contains(indexUser.SearchFilter) || 
                        x.Reservations.Any(o =>
                            o.ReservationId.ToString().Contains(indexUser.SearchFilter)))
                        .ToListAsync();

            }
        }


        public IEnumerable<UserInfo> GetSortUser(IEnumerable<UserInfo> list, string SortItem)
        {
            switch (SortItem)
            {
                case "LastName_ASC":
                    return list.OrderBy(x => x.LastName);
                case "LastName_DESC":
                    return list.OrderByDescending(x => x.LastName);
                case "FirstName_ASC":
                    return list.OrderBy(x => x.FirstName);
                case "FirstName_DESC":
                    return list.OrderByDescending(x => x.FirstName);
                case "UserId_ASC":
                    return list.OrderBy(x => x.UserInfoId);
                case "UserId_DESC":
                    return list.OrderByDescending(x => x.UserInfoId);
                default:
                    return list.OrderBy(x => x.UserInfoId); ;
            }
        }

        public IEnumerable<UserInfo> GetSortUser(IEnumerable<UserInfo> list, string SortItem)
        {
            dataContext.Standards.FromSql("Select * From Standards");
        }

    }
}
