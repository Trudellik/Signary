using System.ComponentModel.DataAnnotations;

namespace Signary.Domain.Entities
{
    public class SignExpression
    {
        public Guid Id { get; set; }

        public string VideoUrl { get; set; }

        public ICollection<SignDefinition> Definitions { get; set; } = new List<SignDefinition>();
    }
}
