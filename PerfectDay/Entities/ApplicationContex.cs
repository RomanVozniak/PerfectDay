using Microsoft.EntityFrameworkCore;

namespace PerfectDay.Entities
{
    public class ApplicationContex : DbContext
    {

        public DbSet<Goal> Goals { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<History> Histories { get; set; }


        public ApplicationContex(DbContextOptions<ApplicationContex> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=perfectdaydb;Trusted_Connection=True;");
        }

    }
}