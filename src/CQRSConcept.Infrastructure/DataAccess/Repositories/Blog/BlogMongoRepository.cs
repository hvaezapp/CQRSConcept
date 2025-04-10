using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Infrastructure.DbContexts.Mongo;
using MongoDB.Driver;

namespace CQRSConcept.Infrastructure.DataAccess.Repositories.Blog
{
    public class BlogMongoRepository : IBlogMongoRepository
    {

        private readonly ICQRSConceptContext _cqrsConceptContext;

        public BlogMongoRepository(ICQRSConceptContext cqrsConceptContext)
        {
            _cqrsConceptContext = cqrsConceptContext;
        }


        public async Task<IEnumerable<Domain.Entities.BlogEntity.Blog>> GetAll(CancellationToken cancellationToken)
        {
            return await _cqrsConceptContext.Blogs.Find(s => true).ToListAsync(cancellationToken);
        }


        public async Task<bool> Create(Domain.Entities.BlogEntity.Blog blog, CancellationToken cancellationToken)
        {
            await _cqrsConceptContext.Blogs.InsertOneAsync(blog, cancellationToken);
            return true;
        }

    }


}
