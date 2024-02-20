using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorApp.BusinessLogic.Services.Abstraction
{
    public interface ISubElementService : IUpsertDeleteService<SubElementUpsertDto, SubElementDto>
    {

    }
}
