using MediatR;
using Signary.Domain.Entities;
using Signary.Infrastructure.Persistence;

namespace Signary.Application.Commands.CreateSignExpression
{
    public class CreateSignExpression : IRequest<Guid>
    {
        public string VideoUrl { get; set; }

    }

    public CreateSignExpressionHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSignExpression request, CancellationToken cancellationToken)
        {
            var signExpression = new SignExpression
            {
                Id = Guid.NewGuid(),
                VideoUrl = request.VideoUrl
            };

            _dbContext.SignExpressions.Add(signExpression);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return signExpression.Id;
        }
    }
}
