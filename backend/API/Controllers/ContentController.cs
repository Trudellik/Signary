using MediatR;
using Microsoft.AspNetCore.Mvc;
using Signary.Application.Queries;

[Route("api/sign-expressions")]
[ApiController]
public class ContentController : ControllerBase
{
    private readonly IMediator _mediator;

    public ContentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSignExpression(Guid id)
    {
        var signExpression = await _mediator.Send(new GetSignExpressionById { Id = id });

        if (signExpression == null)
            return NotFound(new { message = "Sign Expression not found" });

        return Ok(signExpression);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllSignExpressions()
    {
        var query = new GetAllSignExpressions();
        var result = await _mediator.Send(query);
        return Ok(result);
    }
}
