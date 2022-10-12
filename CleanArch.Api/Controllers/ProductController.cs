using Application.Products.Command.Create;
using Application.Products.Queries;
using ClaroFidelizacion.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VideoJuegos.Api.Controllers
{
    public class ProductController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetProductsQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostProductCommand query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
