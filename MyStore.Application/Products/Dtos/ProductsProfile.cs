using AutoMapper;
using MyStore.Domain.Entities;

namespace MyStore.Application.Products.Dtos;
public class ProductsProfile : Profile
{
    public ProductsProfile()
    {
        CreateMap<Product, ProductDto>();
    }
}
