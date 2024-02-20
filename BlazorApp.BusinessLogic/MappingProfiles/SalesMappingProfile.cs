using AutoMapper;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.DataTransferContract.DataTransferObjects.State;

namespace BlazorApp.BusinessLogic.MappingProfiles
{
    internal class SalesMappingProfile : Profile
    {
        public SalesMappingProfile()
        {
            CreateMap<State, StateDto>();
            CreateMap<OrderUpsertDto, Order>();
            CreateMap<Order, OrderDto>();
            CreateMap<WindowUpsertDto, Window>();
            CreateMap<Window, WindowDto>();
            CreateMap<SubElementUpsertDto, SubElement>();
            CreateMap<SubElement, SubElementDto>();
            CreateMap<SubElementType, SubElementTypeDto> ();
        }
    }
}
