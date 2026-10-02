using ApiDAT.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDAT.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosSearsController : ControllerBase
    {
        private readonly PedidoSearsService _pedidoSearsService;

        public PedidosSearsController(
            PedidoSearsService pedidoSearsService)
        {
            _pedidoSearsService = pedidoSearsService;
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerPedidos()
        {
            var pedidos =
                await _pedidoSearsService.ObtenerPedidosAsync();

            return Ok(pedidos);
        }
    }
}