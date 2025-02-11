using MediatR;
using Signary.Application.DTOs;
using AutoMapper;
using Signary.Application.Queries;

public class GetAllSignExpressionsQueryHandler : IRequestHandler<GetAllSignExpressions, List<SignExpressionDto>>
{
    private readonly ISignExpressionRepository _repository;
    private readonly IMapper _mapper;

    public GetAllSignExpressionsQueryHandler(ISignExpressionRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<List<SignExpressionDto>> Handle(GetAllSignExpressions request, CancellationToken cancellationToken)
    {
        var signExpressions = await _repository.GetAllAsync();

        return _mapper.Map<List<SignExpressionDto>>(signExpressions);
    }
}