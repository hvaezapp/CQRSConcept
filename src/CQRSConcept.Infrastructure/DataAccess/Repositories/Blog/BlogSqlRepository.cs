using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Infrastructure.DbContexts.Sql.SqlServer;

namespace CQRSConcept.Infrastructure.DataAccess.Repositories.Blog
{
    public class BlogSqlRepository : IBlogSqlRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogSqlRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<(Domain.Entities.BlogEntity.Blog, bool)> Create(Domain.Entities.BlogEntity.Blog blog, CancellationToken cancellationToken)
        {
            await _dbContext.Set<Domain.Entities.BlogEntity.Blog>().AddAsync(blog, cancellationToken);
            var rowAffected = await _dbContext.SaveChangesAsync(cancellationToken);
            return (blog, rowAffected > 1);
        }

    }


}
