namespace CQRSConcept.Domain.Entities
{
    public abstract class BaseDomainEntity<TKey> 
    {
        public virtual TKey Id { get; protected set; }
        public virtual DateTime CreatedDate { get; private set; }
        public virtual bool IsDeleted { get; private set; }

        protected BaseDomainEntity()
        {
            CreatedDate = DateTime.Now;
        }

    }

    public abstract class BaseEntity : BaseDomainEntity<long>
    {
    }
}
