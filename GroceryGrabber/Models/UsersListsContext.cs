using Microsoft.EntityFrameworkCore;

namespace GroceryGrabber.Models
{
    public class UsersListsContext : DbContext
    {
        public UsersListsContext(DbContextOptions<UsersListsContext> options)
            : base(options)
        { }

        public DbSet<ListsViewModel> usersLists { get; set; } 
    }
}
