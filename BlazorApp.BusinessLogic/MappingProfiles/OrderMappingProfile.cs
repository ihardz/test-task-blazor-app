using AutoMapper;
using BlazorApp.DataAccess.Entities;
using BlazorApp.DataTransferContract.DataTransferObjects.Order;

namespace BlazorApp.BusinessLogic.MappingProfiles
{
    internal class OrderMappingProfile: Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<OrderUpsertDto, Order>();
            CreateMap<Order, OrderDto>();
        }
    }
}
