using ApiDAT.Domain.Entities;

namespace ApiDAT.Application.Interfaces
{
    public interface IPedidoSearsRepository
    {
        Task<IEnumerable<PedidoSears>> ObtenerPedidosAsync();
    }
}