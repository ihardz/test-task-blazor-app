using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface IWindowService : IUpsertDeleteService<WindowUpsertDto, WindowDto>
    {
    }
}
