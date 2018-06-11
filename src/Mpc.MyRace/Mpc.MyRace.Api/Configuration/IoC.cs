namespace Mpc.MyRace.Api.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class IoC
    {
        public static IServiceCollection Setup(this IServiceCollection services, IConfiguration configuration)
        {
            Application.Services.Configuration.IoC.Setup(services, configuration);

            return services;
        }
    }
}
