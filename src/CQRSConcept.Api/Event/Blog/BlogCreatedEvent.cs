using MediatR;

namespace CQRSConcept.Api.Event.Blog
{ 
    public class BlogCreatedEvent : BaseEvent
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public BlogCreatedEvent(long id , string? title, string? description)
        {
            Id = id;
            Title = title;
            Description = description;
            EventName = "BlogCreatedEvent";
        }
    }
}
