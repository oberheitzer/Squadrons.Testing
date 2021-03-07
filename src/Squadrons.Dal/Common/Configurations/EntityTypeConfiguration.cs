using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Squadrons.Model.Common;

namespace Squadrons.Dal.Common
{
    public class EntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasQueryFilter(ent => ent.IsDeleted == false);

            ConfigureEntity(builder);
        }

        public virtual void ConfigureEntity(EntityTypeBuilder<TEntity> builder) { }
    }
}
