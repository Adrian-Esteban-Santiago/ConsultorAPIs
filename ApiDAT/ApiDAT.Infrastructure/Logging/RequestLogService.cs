using ApiDAT.Application.Interfaces;

namespace ApiDAT.Infrastructure.Logging
{
    public class RequestLogService : IRequestLogService
    {
        private readonly string _rutaLogs;

        public RequestLogService(string rutaLogs)
        {
            _rutaLogs = rutaLogs;
        }

        public async Task GuardarRequestAsync(
            string metodo, 
            string endpoint,
            string nombreApi, 
            string contenido)
        {
            Directory.CreateDirectory(_rutaLogs);

            DateTime fechaHora = DateTime.Now;

            string nombreArchivo =
            $"Request_{nombreApi}_{fechaHora:yyyy-MM-dd}.txt";

            string rutaCompleta =
            Path.Combine(_rutaLogs, nombreArchivo);

            string texto = $"""
            ==================================
            REGISTRO DE PETICIÓN
            ==================================

            Fecha y hora: {fechaHora:dd/MM/yyyy HH:mm:ss}
            Método: {metodo}
            Endpoint: {endpoint}
            API: {nombreApi}

            =========================================
            CONTENIDO
            =========================================

            {contenido}
            """;

            await File.AppendAllTextAsync (
                rutaCompleta,
                texto
            );
        }
    }
}