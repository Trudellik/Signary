using AutoMapper;
using MediatR;
using Signary.Domain.Entities;

namespace Signary.Application.Commands
{
    public class CreateSignExpressionHandler : IRequestHandler<CreateSignExpression, Guid>
    {
        private readonly ISignExpressionRepository _repository;
        private readonly IMapper _mapper;

        public CreateSignExpressionHandler(ISignExpressionRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateSignExpression request, CancellationToken cancellationToken)
        {
            var signExpression = _mapper.Map<SignExpression>(request);
            signExpression.Id = Guid.NewGuid();

            await _repository.AddAsync(signExpression);
            await _repository.SaveChangesAsync(cancellationToken);

            return signExpression.Id;
        }
    }
}
