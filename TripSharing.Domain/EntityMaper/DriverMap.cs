using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TripSharing.Domain.Models;

namespace TripSharing.Domain.EntityMaper
{
    public class DriverMap : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            // @todo add more fields
            builder.HasKey(x => x.Id)
                .HasName("pk_driverId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
            builder.Property(x => x.EntryDate)
                .HasColumnName("EntryDate")
                .HasColumnType("datetime");
            builder.Property(x => x.UpdateDate)
                .HasColumnName("UpdateDate")
                .HasColumnType("datetime");
            builder.Property(x => x.IsActive)
                .HasColumnName("IsActive")
                .HasColumnType("bit");
        }
    }
}