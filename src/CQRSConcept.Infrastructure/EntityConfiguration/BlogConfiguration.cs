using CQRSConcept.Domain.Entities.BlogEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CQRSConcept.Infrastructure.EntityConfiguration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(a => a.Title).IsRequired().HasMaxLength(200);

            builder.Property(a => a.Description).IsRequired().HasMaxLength(500);

            builder.HasQueryFilter(p => !p.IsDeleted);

        }
    }

}
