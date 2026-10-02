using ApiDAT.Domain.Entities;

namespace ApiDAT.Application.Interfaces
{
    public interface IDatosDATRepository
    {
        Task<IEnumerable<DatosDAT>> ObtenerDatosAsync();
    }
}