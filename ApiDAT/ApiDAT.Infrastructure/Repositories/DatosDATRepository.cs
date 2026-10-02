using Dapper;
using Microsoft.Data.SqlClient;
using ApiDAT.Application.Interfaces;
using ApiDAT.Domain.Entities;

namespace ApiDAT.Infrastructure.Repositories
{
    public class DatosDATRepository : IDatosDATRepository
    {
        private readonly string _connectionString;

        public DatosDATRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<DatosDAT>> ObtenerDatosAsync()
        {
            const string sql = @"
                SELECT
                    Personas,
                    Edad,
                    Descripcion
                FROM dbo.DatosDAT;
            ";

            using var connection = new SqlConnection(_connectionString);

            return await connection.QueryAsync<DatosDAT>(sql);
        }
    }
}