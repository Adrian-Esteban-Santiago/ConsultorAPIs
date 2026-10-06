namespace ApiDAT.Application.Interfaces
{
    public interface IRequestLogService
    {
        Task GuardarRequestAsync(
            string metodo,
            string endpoint, 
            string nombreApi,
            string contenido
        );
    }
}