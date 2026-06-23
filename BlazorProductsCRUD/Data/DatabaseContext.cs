using BlazorProductsCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorProductsCRUD.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();
    }
}