using CQRSConcept.Domain.Entities.BlogEntity;

namespace CQRSConcept.Domain.Services.BlogServices
{
    public interface IBlogDomainService
    {
        Task<(Blog, bool)> CreateInSql(Blog blog, CancellationToken cancellationToken);
        Task<bool> CreateInMongo(Blog blog, CancellationToken cancellationToken);
        Task<IEnumerable<Blog>> GetAllFromMongo(CancellationToken cancellationToken);
    }
}
