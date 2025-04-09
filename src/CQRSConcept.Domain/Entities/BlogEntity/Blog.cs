namespace CQRSConcept.Domain.Entities.BlogEntity
{
    public class Blog : BaseEntity
    {
        public string? Title { get; private set; }
        public string? Description { get; private set; }
    }
}
