namespace Mpc.MyRace.Domain.Core.UnitOfWorkInterfaces
{
    using Mpc.MyRace.Domain.Core.RepositoryInterfaces;

    public interface IUnitOfWorkMyRace
    {
        IRacerRepository RacerRapository { get; set; }
    }
}
