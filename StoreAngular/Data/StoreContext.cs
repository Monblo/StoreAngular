using Microsoft.EntityFrameworkCore;
using StoreAngular.API.Entities;

namespace StoreAngular.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
