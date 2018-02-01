namespace Mpc.MyRace.Data.Repository.Models
{
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyRace.Data.Repository.Models.Mappings.Configuration;
    using Mpc.MyRace.Data.Repository.Models.Mappings;
    using Mpc.MyRace.Domain.Model;

    public class MyRaceContext : DbContext
    {
        public MyRaceContext(DbContextOptions<MyRaceContext> options) : base(options)
        { }

        public DbSet<Racer> Racers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new RacerMap());
        }
    }
}
