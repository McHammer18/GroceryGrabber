using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options)
: base(options)
        { }

        public DbSet<Lists> Lists { get; set; }
        public DbSet<GroceryItem> GroceryItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lists>().HasData(
                new Lists
                {
                    ListId = 1,
                    UserID = 1,
                    Name = "List1",
                    Items = new List<GroceryItem>()
                }
                );
        }
    }
}
