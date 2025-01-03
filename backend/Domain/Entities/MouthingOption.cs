namespace Signary.Domain.Entities
{
    public class MouthingOption
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public Guid SignDefinitionId { get; set; }
        public SignDefinition SignDefinition { get; set; }
    }

}
