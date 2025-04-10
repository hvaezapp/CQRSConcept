namespace CQRSConcept.Domain.DataAccess.Repositories.Blog
{
    public interface IBlogWriterRepository
    {
        Task<(Entities.BlogEntity.Blog, bool)> Create(Entities.BlogEntity.Blog blog, CancellationToken cancellationToken);
    }
}
