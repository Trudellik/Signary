using MediatR;
using Signary.Application.DTOs;

namespace Signary.Application.Commands
{
    public class CreateSignExpression : IRequest<Guid>
    {
        public string VideoUrl { get; set; }
    }
}
}
