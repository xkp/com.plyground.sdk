namespace Plyground.Gameplay.Runtime
{
    public abstract class GameplayMessage
    {
        public abstract string Id { get; }
        public string CorrelationId { get; set; }
    }
}
