using CQRSConcept.Api.Event.Blog;
using CQRSConcept.Api.Features.Command.Request;
using CQRSConcept.Domain.Entities.BlogEntity;
using CQRSConcept.Domain.Services.BlogServices;
using MediatR;

namespace CQRSConcept.Api.Features.Command.Handler
{
    public class CreateBlogRequestHandler : IRequestHandler<CreateBlogRequest, long>
    {
        private readonly IBlogDomainService _blogDomainService;
        private readonly IMediator _mediator;

        public CreateBlogRequestHandler(IBlogDomainService blogDomainService, IMediator mediator)
        {
            _blogDomainService = blogDomainService;
            _mediator = mediator;
        }

        public async Task<long> Handle(CreateBlogRequest request, CancellationToken cancellationToken)
        {
            var result = await _blogDomainService.CreateInSql(request.blog.Clone() as Blog, cancellationToken);
            if (result.Item2)
                await _mediator.Publish(new BlogCreatedEvent(result.Item1.Id , result.Item1.Title, result.Item1.Description), cancellationToken);
            return result.Item1.Id;
        }
    }
}
