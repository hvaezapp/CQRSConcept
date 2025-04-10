using CQRSConcept.Api.Dtos.Blog;
using MediatR;

namespace CQRSConcept.Api.Features.Command.Request
{
    public class CreateBlogCommandRequest : IRequest<long>
    {
        public CreateBlogDto blog { get; set; }
    }
}
