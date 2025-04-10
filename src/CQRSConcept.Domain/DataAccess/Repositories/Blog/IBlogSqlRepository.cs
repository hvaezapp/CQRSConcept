namespace CQRSConcept.Domain.DataAccess.Repositories.Blog
{
    public interface IBlogSqlRepository
    {
        Task<bool> Create(Entities.BlogEntity.Blog blog, CancellationToken cancellationToken);
    }
}
