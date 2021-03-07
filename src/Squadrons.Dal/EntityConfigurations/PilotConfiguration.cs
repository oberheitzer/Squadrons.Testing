using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Squadrons.Dal.Common;
using Squadrons.Model.Entities;

namespace Squadrons.Dal.EntityConfigurations
{
    public class PilotConfiguration : EntityTypeConfiguration<Pilot>
    {
        public override void ConfigureEntity(EntityTypeBuilder<Pilot> builder)
        {
            builder.HasOne(ent => ent.Ship)
                .WithOne(rev => rev.Pilot)
                .HasForeignKey<Pilot>(ent => ent.ShipId);

            builder.HasOne(ent => ent.Squadron)
                .WithMany(rev => rev.Pilots)
                .HasForeignKey(ent => ent.SquadronId);

            builder.HasIndex(ent => ent.CallSign).IsUnique();
        }
    }
}
