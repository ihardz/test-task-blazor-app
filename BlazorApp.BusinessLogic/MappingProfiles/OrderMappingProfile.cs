using AutoMapper;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;
using BlazorApp.DataTransferContract.DataTransferObjects.State;

namespace BlazorApp.BusinessLogic.MappingProfiles
{
    internal class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<State, StateDto>();
            CreateMap<OrderUpsertDto, Order>();
            CreateMap<Order, OrderDto>();
        }
    }
}
