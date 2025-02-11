using FluentValidation;
using Signary.Infrastructure.Persistence;

namespace Signary.Application.Commands.CreateSignExpression
{
    public class CreateSignExpressionValidator : AbstractValidator<CreateSignExpression>
    {
        private readonly IApplicationDbContext _context;

        public CreateSignExpressionValidator(IApplicationDbContext context)
        {
            RuleFor(x => x.VideoUrl)
                .NotEmpty().WithMessage("Video URL is required")
                .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _)).WithMessage("Invalid URL format");
        }
    }
}
