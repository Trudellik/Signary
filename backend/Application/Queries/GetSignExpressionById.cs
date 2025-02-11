using MediatR;

namespace Signary.Application.Queries
{
    public class GetSignExpressionById : IRequest<SignExpression>
    {
        public Guid Id { get; set; }
    }
}
