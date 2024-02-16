using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.DataAccess.Repositories
{
    internal class StateRepository : SalesRepositoryBase, IStateRepository
    {
        public StateRepository(SalesDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<State>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await DbContext.States.ToListAsync(cancellationToken);
        }
    }
}
