using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Domain.Entities.BlogEntity;

namespace CQRSConcept.Domain.Services.BlogServices
{
    public class BlogDomainService : IBlogDomainService
    {
        private readonly IBlogWriterRepository _blogWriterRepository;
        private readonly IBlogReaderRepository _blogReaderRepository;

        public BlogDomainService(IBlogWriterRepository blogWriterRepository,
                                IBlogReaderRepository blogReaderRepository)
        {
            _blogWriterRepository = blogWriterRepository;
            _blogReaderRepository = blogReaderRepository;
        }


        public async Task<(Blog, bool)> CreateInSql(Blog blog, CancellationToken cancellationToken)
        {
            return await _blogWriterRepository.Create(blog, cancellationToken);
        }



        public async Task<bool> CreateInMongo(Blog blog, CancellationToken cancellationToken)
        {
            return await _blogReaderRepository.Create(blog, cancellationToken);
        }



        public async Task<IEnumerable<Blog>> GetAllFromMongo(CancellationToken cancellationToken)
        {
            return await _blogReaderRepository.GetAll(cancellationToken);
        }

    }
}
