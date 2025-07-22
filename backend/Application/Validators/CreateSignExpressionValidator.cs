using FluentValidation;
using Signary.Application.Commands;

namespace Signary.Application.Validators
{
    public class CreateSignExpressionValidator : AbstractValidator<CreateSignExpression>
    {
        public CreateSignExpressionValidator()
        {
            RuleFor(x => x.VideoUrl)
                .NotEmpty().WithMessage("Video URL is required")
                .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).WithMessage("Invalid URL format");
        }
    }
}
