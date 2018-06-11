namespace Mpc.MyRace.Application.Services.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.MyRace.Application.Services.Implementations;
    using Mpc.MyRace.Application.Services.Interfaces;

    public static class IoC
    {
        public static IServiceCollection Setup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IEventService, EventService>();

            return services;
        }
    }
}
