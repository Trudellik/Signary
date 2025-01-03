namespace Signary.Domain.Entities
{
    public class SignDefinition
    {
        public Guid Id { get; set; }
        public Guid SignExpressionId { get; set; }
        public SignExpression SignExpression { get; set; }
        public string VideoUrl { get; set; }
        public ICollection<MouthingOption> Mouthings { get; set; } = new List<MouthingOption>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<SignDefinitionReference> SourceReferences { get; set; } = new List<SignDefinitionReference>();
        public ICollection<SignDefinitionReference> TargetReferences { get; set; } = new List<SignDefinitionReference>();
    }

}
