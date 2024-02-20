using AutoMapper;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.MappingProfiles
{
    public class DtoMappingProfile : Profile
    {
        public DtoMappingProfile()
        {
            CreateMap<OrderDto, OrderUpsertDto>();
            CreateMap<WindowDto, WindowUpsertDto>();
            CreateMap<SubElementDto, SubElementUpsertDto>();
        }
    }
}
