using CQRSConcept.Api.Event.Blog;
using CQRSConcept.Domain.Services.BlogServices;
using MediatR;

namespace CQRSConcept.Api.Consumers.Blog
{
    public class BlogCreatedEventConsumer : INotificationHandler<BlogCreatedEvent>
    {
        private readonly IBlogDomainService _blogDomainService;

        public BlogCreatedEventConsumer(IBlogDomainService blogDomainService)
        {
            _blogDomainService = blogDomainService;
        }

        public async Task Handle(BlogCreatedEvent eventData, CancellationToken cancellationToken)
        {
            var newBlog = new Domain.Entities.BlogEntity.Blog(eventData.Id ,  eventData.Title, eventData.Description);
            await _blogDomainService.CreateInMongo(newBlog, cancellationToken);
        }
    }
}
