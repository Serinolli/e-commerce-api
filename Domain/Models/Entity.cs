namespace Domain.Models 
{
    public abstract class Entity 
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreationUser { get; set; }
        public DateTime LastUpdate { get; set; }
        protected Entity() 
        {
            Active = true; 
        }
    }
}