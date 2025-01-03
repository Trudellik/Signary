namespace Signary.Domain.Entities
{
    public class SignDefinitionReference
    {
        public Guid Id { get; set; }
        public Guid SourceDefinitionId { get; set; }
        public SignDefinition SourceDefinition { get; set; }
        public Guid TargetDefinitionId { get; set; }
        public SignDefinition TargetDefinition { get; set; }
    }

}
