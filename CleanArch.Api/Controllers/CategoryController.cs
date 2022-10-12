using Application.Category.Category.Commands.Create;
using Application.Category.Category.Commands.Queries;
using ClaroFidelizacion.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VideoJuegos.Api.Controllers
{
    public class CategoryController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetCategoriesQuery query)
        {
            return Ok(await Mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PostCategoryCommand query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
