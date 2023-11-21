using Microsoft.EntityFrameworkCore;

namespace Hospital.Models.Infrastucture
{
    public class MainContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Records> Records { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<ResultOfReferral> ResultOfReferrals { get; set; }
        public DbSet<User> Users { get; set; }

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                    new Gender { Id = 1, Name = "Мужчина" },
                    new Gender { Id = 2, Name = "Женщина" }
               );

            modelBuilder.Entity<Role>().HasData(
                   new Role { Id = 1, Name = "Клиент" },
                   new Role { Id = 2, Name = "Врач" },
                   new Role { Id = 3, Name = "Администратор" }
              );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "Doctor", Password = "Doctor", RoleId = 2},
                new User { Id = 2, Login = "Admin", Password = "Admin", RoleId = 3 }
                );
        }
    }
}
