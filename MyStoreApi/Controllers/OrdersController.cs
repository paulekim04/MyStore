using Microsoft.AspNetCore.Mvc;

namespace MyStoreApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    public async Task<IActionResult> GetAll()
    {

        return Ok();
    }
}
