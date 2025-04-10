using CQRSConcept.Domain.Entities.BlogEntity;
using MongoDB.Driver;

namespace CQRSConcept.Infrastructure.DbContexts.Mongo
{
    public interface ICQRSConceptContext
    {
        IMongoCollection<Blog> Blogs { get; }
    }

}
