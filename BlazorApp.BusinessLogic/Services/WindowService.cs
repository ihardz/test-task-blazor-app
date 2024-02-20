using AutoMapper;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataAccess.Repositories.Abstraction;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.BusinessLogic.Services
{
    internal class WindowService : CreateServiceBase<IWindowRepository, Window, WindowUpsertDto, WindowDto>, IWindowService
    {
        public WindowService(IWindowRepository repository, IMapper mapper) : base(repository, mapper) 
        {
        }
    }
}
