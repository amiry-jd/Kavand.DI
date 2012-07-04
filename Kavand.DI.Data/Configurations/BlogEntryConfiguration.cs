using Kavand.DI.Objects.Entities;

namespace Kavand.DI.Data.Configurations {
    public class BlogEntryConfiguration : ObjectBaseConfiguration<BlogEntry> {
        public BlogEntryConfiguration() {
            Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(256);
            Property(t => t.Abstraction)
                .IsRequired()
                .HasMaxLength(512);
            Property(t => t.Content)
                .IsRequired()
                .HasColumnType("ntext");
            HasMany(t => t.Comments)
                .WithRequired(t => t.Entry)
                .WillCascadeOnDelete(true);
        }
    }
}
