using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Domain.Entities.BlogEntity;

namespace CQRSConcept.Domain.Services.BlogServices
{
    public class BlogDomainService : IBlogDomainService
    {
        private readonly IBlogSqlRepository _blogSqlRepository;
        private readonly IBlogMongoRepository _blogMongoRepository;

        public BlogDomainService(IBlogSqlRepository blogSqlRepository,
                                IBlogMongoRepository blogMongoRepository)
        {
            _blogSqlRepository = blogSqlRepository;
            _blogMongoRepository = blogMongoRepository;
        }


        public async Task<(Blog, bool)> CreateInSql(Blog blog, CancellationToken cancellationToken)
        {
            return await _blogSqlRepository.Create(blog, cancellationToken);
        }



        public async Task<bool> CreateInMongo(Blog blog, CancellationToken cancellationToken)
        {
            return await _blogMongoRepository.Create(blog, cancellationToken);
        }



        public async Task<IEnumerable<Blog>> GetAllFromMongo(CancellationToken cancellationToken)
        {
            return await _blogMongoRepository.GetAll(cancellationToken);
        }

    }
}
