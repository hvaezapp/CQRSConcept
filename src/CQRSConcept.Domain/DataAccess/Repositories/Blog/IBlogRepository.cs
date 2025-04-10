namespace CQRSConcept.Domain.DataAccess.Repositories.Blog
{
    public interface IBlogRepository
    {
        Task<bool> Create(Entities.BlogEntity.Blog blog, CancellationToken cancellationToken);
    }
}
