using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Orders.Queries;

namespace MyStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var orders = await mediator.Send(new GetAllOrdersQuery());

        return Ok(orders);
    }
}
