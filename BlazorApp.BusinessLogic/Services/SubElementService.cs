using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.BusinessLogic.Services
{
    internal class SubElementService : CreateServiceBase<ISubElementRepository, SubElement, SubElementUpsertDto, SubElementDto>, ISubElementService
    {
        public SubElementService(ISubElementRepository repository, IMapper mapper): base(repository, mapper)
        {
        }
    }
}
