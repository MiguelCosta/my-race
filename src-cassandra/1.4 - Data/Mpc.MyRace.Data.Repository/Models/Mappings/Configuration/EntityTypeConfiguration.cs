namespace Mpc.MyRace.Data.Repository.Models.Mappings.Configuration
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void Map(EntityTypeBuilder<TEntity> builder);
    }
}
