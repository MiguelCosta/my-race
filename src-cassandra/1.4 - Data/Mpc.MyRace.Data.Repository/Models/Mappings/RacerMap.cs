namespace Mpc.MyRace.Data.Repository.Models.Mappings
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyRace.Data.Repository.Models.Mappings.Configuration;
    using Mpc.MyRace.Domain.Model;

    public class RacerMap : EntityTypeConfiguration<Racer>
    {
        public override void Map(EntityTypeBuilder<Racer> builder)
        {
            builder.ToTable("Racers");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(r => r.BirthDate)
                .HasColumnName("BirthDate")
                .IsRequired(false);

            builder.Property(r => r.Email)
                .HasColumnName("Email")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(r => r.Gender)
                .HasColumnName("Gender")
                .IsRequired();

            builder.Property(r => r.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();

        }
    }
}
