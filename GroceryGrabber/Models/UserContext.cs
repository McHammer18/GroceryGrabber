using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
    : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    UserId = 1,
                    UserName = "MorganC",
                    Name = "Morgan",
                    Password = "P@ssw0rd1"
                },
                new UserModel
                {
                    UserId = 2,
                    UserName = "LadyLuck",
                    Name = "Taylor",
                    Password = "P@ssw0rd1"
                },
                new UserModel
                {
                    UserId = 3,
                    UserName = "DeonD",
                    Name = "Deaon",
                    Password = "P@ssw0rd1"
                }

            );
        }
    }
}
