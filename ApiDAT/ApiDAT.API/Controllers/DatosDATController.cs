using ApiDAT.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDAT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosDATController : ControllerBase
    {
        private readonly DatosDATService _datosDATService;

        public DatosDATController(DatosDATService datosDATService)
        {
            _datosDATService = datosDATService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerDatos()
        {
            var datos = await _datosDATService.ObtenerDatosAsync();

            return Ok(datos);
        }
    }
}