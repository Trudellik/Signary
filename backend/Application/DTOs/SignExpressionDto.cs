using Signary.Application.DTOs;

public class SignExpressionDto
{
    public Guid Id { get; set; }
    public string VideoUrl { get; set; }
    public List<SignDefinitionDto> Definitions { get; set; }
}