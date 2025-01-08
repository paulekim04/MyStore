using AutoMapper;
using MediatR;
using MyStore.Application.Orders.Dtos;
using MyStore.Domain.Repositories;

namespace MyStore.Application.Orders.Queries;
internal class GetAllOrdersQueryHandler
    (
    IOrdersRepository ordersRepository,
    IMapper mapper
    )
    : IRequestHandler<GetAllOrdersQuery, IEnumerable<OrderDto>>
{
    public async Task<IEnumerable<OrderDto>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await ordersRepository.GetAllAsync();

        var ordersDto = mapper.Map<IEnumerable<OrderDto>>(orders);

        return ordersDto;
    }
}
