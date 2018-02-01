namespace Mpc.MyRace.Data.Repository.RepositoryImplementations
{
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyRace.Domain.Core.RepositoryInterfaces;
    using Mpc.MyRace.Domain.Model;

    public class RacerRepository : GenericRepository<Racer>, IRacerRepository
    {
        public RacerRepository(DbContext dbContext) : base(dbContext) { }
    }
}
