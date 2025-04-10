using CQRSConcept.Domain.Entities.BlogEntity;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CQRSConcept.Infrastructure.DbContexts.Mongo
{
    public class CQRSConceptContext : ICQRSConceptContext
    {
        public IMongoCollection<Blog> Blogs { get; }

        public CQRSConceptContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetSection("ConnectionStrings:Mongo:ConnectionString").Value);
            var database = client.GetDatabase(configuration.GetSection("ConnectionStrings:Mongo:DatabaseName").Value);
            Blogs = database.GetCollection<Blog>(configuration.GetSection("ConnectionStrings:Mongo:CollectionName").Value);
        }
    }

}
