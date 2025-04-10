namespace CQRSConcept.Domain.DataAccess.Repositories.Blog
{
    public interface IBlogSqlRepository
    {
        Task<(Entities.BlogEntity.Blog, bool)> Create(Entities.BlogEntity.Blog blog, CancellationToken cancellationToken);
    }
}
