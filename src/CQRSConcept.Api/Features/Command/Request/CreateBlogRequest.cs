using CQRSConcept.Api.Dtos.Blog;
using MediatR;

namespace CQRSConcept.Api.Features.Command.Request
{
    public class CreateBlogRequest : IRequest<long>
    {
        public CreateBlogDto blog { get; set; }
    }
}
