using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class GroceryContext : IdentityDbContext
    {
        public GroceryContext(DbContextOptions<GroceryContext> options)
            : base(options)
        { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<GroceryItem> GroceryItems { get; set; }
        public DbSet<UsersLists> GroceryList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GroceryItem>().HasData(
                new GroceryItem
                {
                    GroceryId = 1,
                    Name = "1lbs Hamburger",
                    Description = "Role of ground Hamburger Meat",
                    Department = "Meat",
                    Location = "Meat Counter/ Aisle 65"
                },
                new GroceryItem
                {
                    GroceryId = 2,
                    Name = "Lettuce",
                    Description = "1 Head of Iceburg Lettuce",
                    Department = "Produce",
                    Location = "Aisle 42"
                },
                new GroceryItem
                {
                    GroceryId = 3,
                    Name = "Apples",
                    Description = "5 lbs bag of Honey Crisp",
                    Department = "Produce",
                    Location = "Aisle 44"
                },
                new GroceryItem
                {
                    GroceryId = 4,
                    Name = "Sliced Turkey",
                    Description = "1 lbs of Turkey slices",
                    Department = "Deli",
                    Location = "Deli Counter/ Aisle 55"
                },
                new GroceryItem
                {
                    GroceryId = 5,
                    Name = "Bread",
                    Description = "1 loaf of White Whole Grain",
                    Department = "Bakery",
                    Location = "Aisle 20"
                }
             );

            //modelBuilder.Entity<UsersLists>().HasData(
               // new UsersLists
               // {
               //     id = 1,
              //      UserID = 1,
               //     GroceryId = 1
             //   });

        }


        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            using (var scoped = serviceProvider.CreateScope())
            {
                UserManager<UserModel> userManager = scoped.ServiceProvider.GetRequiredService<UserManager<UserModel>>();
                RoleManager<IdentityRole> roleManager = scoped.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                string username = "admin";
                string pwd = "admin";
                string roleName = "Admin";

                if (await roleManager.FindByNameAsync(roleName) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(roleName));
                }

                if (await userManager.FindByNameAsync(username) == null)
                {
                    UserModel user = new UserModel() { UserName = username };
                    var result = await userManager.CreateAsync(user, pwd);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, roleName);
                    }
                }
            }
        }

    }
}
