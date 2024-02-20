using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace BlazorApp.DataAccess.Repositories
{
    internal class SubElementTypeRepository : SalesRepositoryBase, ISubElementTypeRepository
    {
        public SubElementTypeRepository(SalesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<SubElementType>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext.SubElementTypes.ToListAsync(cancellationToken);
        }
    }
}
