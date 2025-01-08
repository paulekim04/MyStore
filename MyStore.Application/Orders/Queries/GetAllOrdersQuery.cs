using MediatR;
using MyStore.Application.Orders.Dtos;

namespace MyStore.Application.Orders.Queries;
public class GetAllOrdersQuery : IRequest<IEnumerable<OrderDto>>
{
}


