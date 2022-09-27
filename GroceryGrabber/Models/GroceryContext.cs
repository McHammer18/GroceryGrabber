using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class GroceryContext : DbContext
    {
        public GroceryContext(DbContextOptions<GroceryContext> options)
            : base(options)
        { }

        public DbSet<GroceryItem> GroceryItems { get; set; }

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
        }

    }
}
