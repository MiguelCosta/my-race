namespace Mpc.MyRace.Data.Repository.DependenciesConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.MyRace.Data.Repository.Implementations;
    using Mpc.MyRace.Data.Repository.Models;
    using Mpc.MyRace.Data.Repository.RepositoryImplementations;
    using Mpc.MyRace.Domain.Core.RepositoryInterfaces;
    using Mpc.MyRace.Domain.Core.UnitOfWorkInterfaces;

    public static class RepositoryDependenciesConfiguration
    {
        public static IServiceCollection ConfigurationRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUnitOfWorkMyRace, UnitOfWorkMyRace>();
            services.AddTransient<IRacerRepository, RacerRepository>();

            services.AddDbContext<MyRaceContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MyRaceConnectionString")));

            return services;
        }
    }
}
