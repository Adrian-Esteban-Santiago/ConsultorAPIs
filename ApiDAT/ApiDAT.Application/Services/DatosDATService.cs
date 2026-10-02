
using ApiDAT.Application.Interfaces;
using ApiDAT.Domain.Entities;

namespace ApiDAT.Application.Services
{
    public class DatosDATService
    {
        private readonly IDatosDATRepository _datosDATRepository;

        public DatosDATService(IDatosDATRepository datosDATRepository)
        {
            _datosDATRepository = datosDATRepository;
        }

        public async Task<IEnumerable<DatosDAT>> ObtenerDatosAsync()
        {
            return await _datosDATRepository.ObtenerDatosAsync();
        }
    }
}