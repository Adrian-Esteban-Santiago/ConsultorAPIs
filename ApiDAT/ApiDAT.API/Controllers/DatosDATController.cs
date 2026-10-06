using ApiDAT.Application.Services;
using Microsoft.AspNetCore.Mvc;
using ApiDAT.Application.Interfaces;

namespace ApiDAT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosDATController : ControllerBase
    {
        private readonly DatosDATService _datosDATService;
        private readonly IRequestLogService _requestLogService;

        public DatosDATController(
            DatosDATService datosDATService,
            IRequestLogService requestLogService)
        {
            _datosDATService = datosDATService;
            _requestLogService = requestLogService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerDatos()
        {
            var datos = await _datosDATService.ObtenerDatosAsync();

            var contenido = string.Join(
                Environment.NewLine,
                datos.Select( d =>
                $"{d.Personas} | {d.Edad} | {d.Descripcion}"
                )
            );

            await _requestLogService.GuardarRequestAsync(
        Request.Method,
        Request.Path,
        "DatosDAT",
        contenido
            );

            return Ok(datos);
        }
    }
}