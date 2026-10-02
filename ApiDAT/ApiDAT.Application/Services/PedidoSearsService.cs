using ApiDAT.Application.Interfaces;
using ApiDAT.Domain.Entities;

namespace ApiDAT.Application.Services
{
    public class PedidoSearsService
    {
        private readonly IPedidoSearsRepository _pedidoSearsRepository;

        public PedidoSearsService(
            IPedidoSearsRepository pedidoSearsRepository)
        {
            _pedidoSearsRepository = pedidoSearsRepository;
        }

        public async Task<IEnumerable<PedidoSears>> ObtenerPedidosAsync()
        {
            return await _pedidoSearsRepository.ObtenerPedidosAsync();
        }
    }
}