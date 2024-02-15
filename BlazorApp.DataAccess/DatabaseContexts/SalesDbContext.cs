using BlazorApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.DataAccess.DatabaseContexts
{
    internal class SalesDbContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        public SalesDbContext(DbContextOptions<SalesDbContext> options)
            : base(options)
        {

        }
    }
}
