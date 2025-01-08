using MediatR;
using MyStore.Application.Products.Dtos;

namespace MyStore.Application.Products.Queries;
public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
{
}
