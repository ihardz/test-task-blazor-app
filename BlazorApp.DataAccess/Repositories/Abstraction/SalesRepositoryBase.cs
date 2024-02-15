using BlazorApp.DataAccess.DatabaseContexts;

namespace BlazorApp.DataAccess.Repositories.Abstraction
{
    internal abstract class SalesRepositoryBase
    {
        protected SalesDbContext DbContext { get; }

        protected SalesRepositoryBase(SalesDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}
