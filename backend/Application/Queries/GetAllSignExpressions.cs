using MediatR;
using Signary.Application.DTOs;

namespace Signary.Application.Queries
{
    public class GetAllSignExpressions : IRequest<List<SignExpressionDto>> { }
}
