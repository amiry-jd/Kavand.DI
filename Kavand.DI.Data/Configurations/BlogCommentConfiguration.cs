using Kavand.DI.Objects.Entities;

namespace Kavand.DI.Data.Configurations {
    public class BlogCommentConfiguration :  ObjectBaseConfiguration<BlogComment> {
        public BlogCommentConfiguration() {
            Property(t => t.Content)
                .IsRequired()
                .HasMaxLength(512);
        }
    }
}