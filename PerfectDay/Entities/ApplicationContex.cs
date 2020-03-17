using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PerfectDay.Entities
{
    public class ApplicationContex : DbContext
    {
<<<<<<< HEAD
        public DbSet<Goal> goals { get; set; }
        public DbSet<User> users { get; set; }
=======
        public DbSet<Goal> Goals { get; set; }
>>>>>>> f6a89a83ea0b18c5b991e44fd966537ac214a12f

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=perfectdaydb;Trusted_Connection=True;");
        }
    }
}
