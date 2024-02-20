using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services
{
    internal class SubElementService : UpsertDeleteServiceBase<ISubElementRepository, SubElement, SubElementUpsertDto, SubElementDto>, ISubElementService
    {
        public SubElementService(ISubElementRepository repository, IMapper mapper): base(repository, mapper)
        {
        }
    }
}
