namespace CQRSConcept.Domain.Entities
{
    public interface IEntity { }
    public abstract class BaseDomainEntity<TKey> : IEntity
    {
        public virtual TKey Id { get; protected set; }
        public virtual DateTime CreatedDate { get; private set; }
        public virtual DateTime LastModifiedDate { get; private set; }
        public virtual bool IsDeleted { get; private set; }

        protected BaseDomainEntity()
        {
            CreatedDate = DateTime.Now;
        }

        public void UpdateLastModifiedDate()
        {
            LastModifiedDate = DateTime.Now;
        }
    }

    public abstract class BaseEntity : BaseDomainEntity<long>
    {
    }
}
