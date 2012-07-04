using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Kavand.DI.Objects;

namespace Kavand.DI.Data.Configurations {
    public abstract class ObjectBaseConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : ObjectBase {
        protected ObjectBaseConfiguration() {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.CreatedAt).IsRequired();
            Property(t => t.UpdatedAt).IsRequired();
        }
    }
}