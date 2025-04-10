using CQRSConcept.Api.Dtos.Blog;
using MediatR;

namespace CQRSConcept.Api.Features.Query.Request
{
    public class GetBlogQueryRequest : IRequest<List<GetBlogDto>>
    {
    }
}
