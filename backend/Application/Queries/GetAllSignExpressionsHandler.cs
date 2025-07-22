using MediatR;
using AutoMapper;
using Signary.Application.Queries;

public class GetAllSignExpressionsHandler : IRequestHandler<GetAllSignExpressions, List<SignExpressionDto>>
{
    private readonly ISignExpressionRepository _repository;
    private readonly IMapper _mapper;

    public GetAllSignExpressionsHandler(ISignExpressionRepository repository, IMapper mapper)
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