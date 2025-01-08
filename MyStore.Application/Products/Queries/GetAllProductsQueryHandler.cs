using AutoMapper;
using MediatR;
using MyStore.Application.Products.Dtos;
using MyStore.Domain.Repositories;

namespace MyStore.Application.Products.Queries;
public class GetAllProductsQueryHandler
    (
    IProductsRepository productsRepository,
    IMapper mapper
    ) 
    : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>
{
    public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = await productsRepository.GetAllAsync();

        var productsDto = mapper.Map<IEnumerable<ProductDto>>(products);

        return productsDto;
    }
}
