namespace CQRSConcept.Domain.Entities.BlogEntity
{
    public class Blog : BaseEntity 
    {

        #region props
        public string? Title { get; private set; }
        public string? Description { get; private set; }
        #endregion


        #region ctors
        public Blog(string? title, string? description)
        {
            Title = title;
            Description = description;
        }


        public Blog(long id , string? title, string? description)
        {
            Id = id;
            Title = title;
            Description = description;
        }


        #endregion


     

    }
}
