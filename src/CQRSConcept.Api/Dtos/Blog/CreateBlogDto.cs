namespace CQRSConcept.Api.Dtos.Blog
{
    public class CreateBlogDto : ICloneable
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public object Clone()
        {
            return new Domain.Entities.BlogEntity.Blog(Title, Description);
        }
    }
}
