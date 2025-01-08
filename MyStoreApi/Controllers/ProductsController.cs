using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyStore.Application.Products.Queries;

namespace MyStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController(IMediator mediator) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await mediator.Send(new GetAllProductsQuery());

        return Ok(products);
    }
}
