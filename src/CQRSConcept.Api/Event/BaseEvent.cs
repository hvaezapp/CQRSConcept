using MediatR;

namespace CQRSConcept.Api.Event
{
    public class BaseEvent : INotification
    {
        public string? EventId { get; set; }
        public string? EventName { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEvent()
        {
            EventId = Guid.NewGuid().ToString();
            CreatedOn = DateTime.Now;
        }
    }
}
