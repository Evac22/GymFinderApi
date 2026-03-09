namespace GymFinderApi.Infrastructure.Postgres
{
    using GymFinderApi.Application.Database;
    using GymFinderApi.Application.Gyms;
    using GymFinderApi.Infrastructure.Postgres.Repositories;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddPostgresInfrastructure(this IServiceCollection services)
        {
          services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();
         
          services.AddScoped<IGymsRepository, GymSqlRepository>();

          return services;
        }
    }
}
