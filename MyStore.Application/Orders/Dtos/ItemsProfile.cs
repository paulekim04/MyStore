using AutoMapper;
using MyStore.Domain.Entities;

namespace MyStore.Application.Orders.Dtos;

public class ItemsProfile : Profile
{
    public ItemsProfile()
    {
        CreateMap<Item, ItemDto>();
    }
}
