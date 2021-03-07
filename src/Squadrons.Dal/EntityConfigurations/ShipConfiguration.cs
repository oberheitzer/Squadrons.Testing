using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Squadrons.Dal.Common;
using Squadrons.Model.Entities;

namespace Squadrons.Dal.EntityConfigurations
{
    public class ShipConfiguration : EntityTypeConfiguration<Ship>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Ship> builder)
        {
            builder.HasIndex(ent => ent.TransponderCode).IsUnique();

            builder.HasOne(ent => ent.Pilot)
                .WithOne(rev => rev.Ship)
                .HasForeignKey<Ship>(ent => ent.PilotId);
        }
    }
}
