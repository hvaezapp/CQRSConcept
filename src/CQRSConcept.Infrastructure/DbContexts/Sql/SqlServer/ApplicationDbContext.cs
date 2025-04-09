using CQRSConcept.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace CQRSConcept.Infrastructure.DbContexts.Sql.SqlServer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(BlogConfiguration).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }

    }
}
