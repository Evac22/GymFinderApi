namespace GymFinderApi.Infrastructure.Postgres.Repositories
{
    using System.Data;
    using GymFinderApi.Application.Database;
    using Microsoft.Extensions.Configuration;
    using Npgsql;

    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Create()
        {
            var connecting = new NpgsqlConnection(_configuration.GetConnectionString("Database"));
            return connecting;
        }
    }
}
