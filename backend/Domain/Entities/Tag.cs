namespace Signary.Domain.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<SignDefinition> Definitions { get; set; } = new List<SignDefinition>();
    }
}
