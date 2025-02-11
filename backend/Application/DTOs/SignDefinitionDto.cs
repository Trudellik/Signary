namespace Signary.Application.DTOs
{
    public class SignDefinitionDto
    {
        public Guid Id { get; set; }
        public string VideoUrl { get; set; }
        public List<MouthingOptionDto> Mouthings { get; set; }
        public List<TagDto> Tags { get; set; }
    }
}
