namespace GymFinderApi.Application
{
    using FluentValidation;
    using GymFinderApi.Application.Gyms;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);
            services.AddScoped<IGymsService, GymsService>();

            return services;
        }
    }
}
