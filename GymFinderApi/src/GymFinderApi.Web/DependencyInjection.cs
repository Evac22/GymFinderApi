namespace GymFinderApi.Web
{
    using GymFinderApi.Application;

    public static class DependencyInjection
    {
        public static IServiceCollection AddProgramDependencies(this IServiceCollection services)
        {
            return services.AddWebDependecies()
            .AddApplication();
        }

        private static IServiceCollection AddWebDependecies(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddOpenApi();
            return services;
        }
    }
}
