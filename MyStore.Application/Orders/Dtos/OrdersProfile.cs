using AutoMapper;
using MyStore.Domain.Entities;

namespace MyStore.Application.Orders.Dtos;

public class OrdersProfile : Profile
{
    public OrdersProfile()
    {
        CreateMap<Order, OrderDto>();
    }
}
