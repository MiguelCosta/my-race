namespace Mpc.MyRace.Data.Repository.Implementations
{
    using Mpc.MyRace.Domain.Core.RepositoryInterfaces;
    using Mpc.MyRace.Domain.Core.UnitOfWorkInterfaces;

    public class UnitOfWorkMyRace : IUnitOfWorkMyRace
    {
        public IRacerRepository RacerRapository { get; set; }
    }
}
