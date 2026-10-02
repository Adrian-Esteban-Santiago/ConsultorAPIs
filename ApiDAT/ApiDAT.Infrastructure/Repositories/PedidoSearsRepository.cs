using ApiDAT.Application.Interfaces;
using ApiDAT.Domain.Entities;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ApiDAT.Infrastructure.Repositories
{
    public class PedidoSearsRepository : IPedidoSearsRepository
    {
        private readonly string _connectionString;

        public PedidoSearsRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<PedidoSears>> ObtenerPedidosAsync()
        {
            const string sql = @"
                SELECT
                    Folio,
                    cliente AS Cliente,
                    Tipo,
                    Monto,
                    Estado,
                    Fecha
                FROM dbo.Pedidos_Sears;
            ";

            using var connection =
                new SqlConnection(_connectionString);

            return await connection.QueryAsync<PedidoSears>(sql);
        }
    }
}