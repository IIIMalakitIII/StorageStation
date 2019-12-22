using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using MyUniversityProject.Models.StorageViewModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public async Task<Employee> GetEpmloyee(int Id) =>
            await dataContext.Employee.FirstOrDefaultAsync(o => o.EmployeeId == Id);

        public SqlViewModel DashBoard(SqlViewModel sqlView)
        {
            var conn = dataContext.Database.GetDbConnection().ConnectionString;
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlView.SqlCommand, connection);
                
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataColumn column in dt.Columns)
                        sqlView.ColumName.Add(column.ColumnName);
                    foreach (DataRow row in dt.Rows)
                    {
                        // получаем все ячейки строки
                        var cells = row.ItemArray;
                        sqlView.RowName.Add(cells);
                    }
                }
                connection.Close();
            }
            return sqlView;
        }

        public async Task<IEnumerable<Employee>> GetAdmins(string sortOrder, string searching) 
        {

            var list = dataContext.Employee
                        .AsNoTracking()
                        .Where(o =>
                            o.LastName.Contains(searching) ||
                            o.FirstName.Contains(searching) ||
                            o.PassportId.Contains(searching) ||
                            o.PhoneNumber.Contains(searching) ||
                            o.Position.Contains(searching) ||
                            o.Salary.ToString().Contains(searching) ||
                            o.Email.Contains(searching) ||
                            o.EmployeeId.ToString().Contains(searching));

            switch (sortOrder)
            {
                case "LastName":
                    return await list
                        .OrderBy(o => o.LastName).ToListAsync();
                case "id":
                    return await list
                        .OrderByDescending(o => o.EmployeeId).ToListAsync();
                case "lastName":
                    return await list
                        .OrderByDescending(o => o.LastName).ToListAsync();
                case "FirstName":
                    return await list
                        .OrderBy(o => o.FirstName).ToListAsync();
                case "firstName":
                    return await list
                        .OrderByDescending(o => o.FirstName).ToListAsync();
                default:
                    return await list
                        .OrderBy(o => o.EmployeeId).ToListAsync();
            }
        }
            

        public async Task<string> CreateAdmins(Employee employee)
        {
            if(await dataContext.Employee.AnyAsync(x=> x.Email == employee.Email))
            {
                return "Sorry, but this email is used";
            }
            if (employee.Role !="Admin")
            {
                return "Sorry, but you can create only Admin";
            }
            employee.Password = Cryptography.Encrypt(employee.Password);
            await dataContext.Employee.AddAsync(employee);
            var result = await SaveAsync();

            return result;
        }
        public async Task<string> UpdateAdmin(Employee employee)
        {
            if (await dataContext.Employee.AnyAsync(x => x.EmployeeId == employee.EmployeeId))
            {
                dataContext.Employee.Update(employee);
                var result = await SaveAsync();

                return result;
            }
            return $"Something wrong, can't find admin with this Id: {employee.EmployeeId}";
        }

        public async Task<string> DeleteAdmin(int employeeId)
        {
            var reserve = await GetEpmloyee(employeeId);

            if (reserve == null)
            {
                return $"Did not find a reservation by this id = {employeeId}";
            }
            dataContext.Remove(reserve);
            var result = await SaveAsync();
            return result;

        }
    }
}
