using System.Data.Entity;
using Kavand.DI.Data.Configurations;
using Kavand.DI.Objects.Entities;

namespace Kavand.DI.Data.Parts {
    public class EntityContext : DbContext {
        static EntityContext() {
            //Database.SetInitializer<EntityContext>(null);
        }
        public DbSet<BlogEntry> BlogEntries { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new BlogEntryConfiguration());
            modelBuilder.Configurations.Add(new BlogCommentConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
        }
    }
}
