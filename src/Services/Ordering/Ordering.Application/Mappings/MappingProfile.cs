using AutoMapper;
using Ordering.Domain.Entities;
using Ordering.Application.Features.Orders.Commands.CheckouOrder;
using Ordering.Application.Features.Orders.Queries.GetOrderList;
using Ordering.Application.Features.Orders.Commands.UpdateOrder;

namespace Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrdersVm>().ReverseMap();
            CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
            CreateMap<Order, UpdateOrderCommandHandler>().ReverseMap();


        }
    }
}
