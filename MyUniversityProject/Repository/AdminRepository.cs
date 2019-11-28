using Microsoft.EntityFrameworkCore;
using MyUniversityProject.IRepository;
using MyUniversityProject.Models;
using MyUniversityProject.Models.AuthenticationModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

        public async Task<string> DashBoard(string sql)
        {

            List<string> slem = new List<string>();
            var conn = dataContext.Database.GetDbConnection();
            try
            {
                await conn.OpenAsync();
                using (var command = conn.CreateCommand())
                {
                    string query = sql;
                    command.CommandText = query;
                    DbDataReader reader = await command.ExecuteReaderAsync();
                    
                    if (reader.HasRows)
                    {
                        var name4 = reader.OfType<string>();

                        DataTable schemaTable = reader.GetSchemaTable();
                        foreach (DataRow row in schemaTable.Rows)
                        {
                            foreach (DataColumn column in schemaTable.Columns)
                            {
                                slem.Add(String.Format("{0} = {1}",
                                   column.ColumnName, row[column]));
                            }
                        }
                        //while (await reader.ReadAsync())
                        //{
                        //    //var row = new EnrollmentDateGroup { EnrollmentDate = reader.GetDateTime(0), StudentCount = reader.GetInt32(1) };
                        //    slem.Add(reader.GetString(0));
                        //}
                    }
                    conn.Close();
                    conn.Close();
                    conn.Close();
                    conn.Close();
                    conn.Close();
                    reader.Dispose();
                }
                return "";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                conn.Close();
            }/*
            try {

                await con.OpenAsync();
                List<string> slem = new List<string>();
                //using (SqlConnection sqlconn = new SqlConnection("Server = (local)\\SQLEXPRESS; Database = MyUnix; Integrated Security = True"))
                //{
                //    sqlconn.Open();
                //    SqlDataAdapter oda = new SqlDataAdapter(sql, sqlconn);
                //    DataTable dt = new DataTable();
                //    oda.
                //    sqlconn.Close();
                //    return "good";
                //}
                SqlConnection sqlconn = new SqlConnection(@"Data Source = DESKTOP-GL9OQQC\SQLEXPRESS; Initial Catalog = MyUnix; Integrated Security = True");
                using (SqlCommand command = new SqlCommand(sql, dataContext.Database.GetDbConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        slem.Add(reader.GetString(0));
                        slem.Add(reader.GetString(1));
                        }
                    }
                }
            return "";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }*/
        }

    }
}
