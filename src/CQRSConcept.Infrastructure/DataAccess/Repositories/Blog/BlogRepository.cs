using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Infrastructure.DbContexts.Sql.SqlServer;

namespace CQRSConcept.Infrastructure.DataAccess.Repositories.Blog
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BlogRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Create(Domain.Entities.BlogEntity.Blog blog, CancellationToken cancellationToken)
        {
            await _dbContext.Set<Domain.Entities.BlogEntity.Blog>().AddAsync(blog, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
    }


}
