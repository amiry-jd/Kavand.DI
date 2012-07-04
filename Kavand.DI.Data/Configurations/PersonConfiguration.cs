using Kavand.DI.Objects.Entities;

namespace Kavand.DI.Data.Configurations {
    public class PersonConfiguration : System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<Person> {
        public PersonConfiguration() {
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(32);
            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(64);
            Property(t => t.WebAddr)
                .IsOptional()
                .HasMaxLength(2024);
        }
    }
}