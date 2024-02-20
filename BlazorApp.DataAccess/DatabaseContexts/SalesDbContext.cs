using BlazorApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.DataAccess.DatabaseContexts
{
    internal class SalesDbContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Window> Windows { get; set; }
        public virtual DbSet<SubElement> SubElements { get; set; }
        public virtual DbSet<SubElementType> SubElementTypes { get; set; }

        public SalesDbContext(DbContextOptions<SalesDbContext> options)
            : base(options)
        {

        }
    }
}
