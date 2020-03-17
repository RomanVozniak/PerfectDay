using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PerfectDay.Entities
{
    public class ApplicationContex : DbContext
    {
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public ApplicationContex()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=prefrectdaydb;Trusted_Connection=True;");
        }
    }
}
