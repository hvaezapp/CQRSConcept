using CQRSConcept.Api.Dtos.Blog;
using CQRSConcept.Api.Features.Query.Request;
using CQRSConcept.Domain.Services.BlogServices;
using MediatR;

namespace CQRSConcept.Api.Features.Query.Handler
{
    public class GetBlogQueryRequestHandler : IRequestHandler<GetBlogQueryRequest, List<GetBlogDto>>
    {
        private readonly IBlogDomainService _blogDomainService;

        public GetBlogQueryRequestHandler(IBlogDomainService blogDomainService)
        {
            _blogDomainService = blogDomainService;
        }

        public async Task<List<GetBlogDto>> Handle(GetBlogQueryRequest request, CancellationToken cancellationToken)
        {
          return (await _blogDomainService.GetAllFromMongo(cancellationToken)).Select(b => new GetBlogDto
           {
               Id = b.Id,
               Title  = b.Title,
               Description = b.Description,

           }).ToList();
        }
    }
}
