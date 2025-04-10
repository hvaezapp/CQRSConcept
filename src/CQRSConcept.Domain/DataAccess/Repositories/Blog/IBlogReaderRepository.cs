namespace CQRSConcept.Domain.DataAccess.Repositories.Blog
{
    public interface IBlogReaderRepository
    {
        Task<IEnumerable<Entities.BlogEntity.Blog>> GetAll(CancellationToken cancellationToken);
        Task<bool> Create(Entities.BlogEntity.Blog blog, CancellationToken cancellationToken);
    }
}
