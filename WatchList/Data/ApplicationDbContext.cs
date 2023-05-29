using Microsoft.EntityFrameworkCore;
using WatchList.Models;

namespace WatchList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}
