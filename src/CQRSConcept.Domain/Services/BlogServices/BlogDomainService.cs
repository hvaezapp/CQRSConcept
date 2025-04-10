using CQRSConcept.Domain.DataAccess.Repositories.Blog;
using CQRSConcept.Domain.Entities.BlogEntity;

namespace CQRSConcept.Domain.Services.BlogServices
{
    public sealed class BlogDomainService
    {
        private readonly IBlogSqlRepository _blogRepository;

        public BlogDomainService(IBlogSqlRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }


        public async Task<bool> Create(Blog blog , CancellationToken cancellationToken)
        {
            // domain logic here ...
            return await _blogRepository.Create(blog , cancellationToken);
        } 
    }
}
