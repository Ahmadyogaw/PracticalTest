using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Features.UserFeatures.GetAllSportEvents;
using CleanArchitecture.Application.Features.UserFeatures.GetUser;
using CleanArchitecture.Application.Features.UserFeatures.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("api/v1/sport-events")]
public class SportsController : ControllerBase
{
    private readonly IMediator _mediator;

    public SportsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateUserResponse>> CreateUser([FromBody]CreateUserRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult<GetUserResponse>> GetUser([FromQuery]GetUserRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetAllSportEventsResponse>> GetListSportEvent([FromQuery]GetAllSportEventsRequest request, CancellationToken cancellationToken)
    {
        var data = request;
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut("{Id}")]
    public async Task<ActionResult<GetUserResponse>> UpdateUser([FromQuery]GetUserRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [HttpDelete("{Id}")]
    public async Task<ActionResult<GetUserResponse>> DeleteUser([FromQuery]GetUserRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}