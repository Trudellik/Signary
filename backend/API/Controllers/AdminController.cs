using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Signary.Domain.Entities;
using Signary.Application.Commands.CreateSignExpression;

[ApiController]
[Route("api/admin/sign-expressions")]
[Authorize(Roles = "Admin")]
public class AdminController : ControllerBase
{
    private readonly IMediator _mediator;

    public AdminController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSignExpression([FromBody] CreateSignExpression command)
    {
        var signExpressionId = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetSignExpression), new { id = signExpressionId }, null);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSignExpression(Guid id, [FromBody] UpdateSignExpression command)
    {
        if (id != command.Id)
            return BadRequest("Mismatched SignExpression ID");

        var updatedSignExpression = await _mediator.Send(command);
        return updatedSignExpression != null ? Ok(updatedSignExpression) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSignExpression(Guid id)
    {
        var result = await _mediator.Send(new DeleteSignExpression { Id = id });
        return result ? NoContent() : NotFound();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSignExpression(Guid id)
    {
        var signExpression = await _mediator.Send(new GetSignExpressionQuery { Id = id });

        if (signExpression == null)
            return NotFound(new { message = "Sign Expression not found" });

        return Ok(signExpression);
    }
}
