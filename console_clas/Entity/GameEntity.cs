namespace console_clas.Entity
{
    public abstract class GameEntity
    {
        public Guid Id { get; }
        
        protected GameEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
