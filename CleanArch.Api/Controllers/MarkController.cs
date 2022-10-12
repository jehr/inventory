using Application.Mark.Queries;
using ClaroFidelizacion.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VideoJuegos.Api.Controllers
{
    public class MarkController : ApiControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetMarkQuery query)
        {
            return Ok(await Mediator.Send(query));
        }
    }
}
