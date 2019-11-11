using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Cell> Cells { get; set; }
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Schedule> Schedule { get; set; }

    }
}
