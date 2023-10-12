using System.Text.Json;
using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Features.UserFeatures.DeleteUser;
using CleanArchitecture.Application.Features.UserFeatures.GetUser;
using CleanArchitecture.Application.Features.UserFeatures.Login;
using CleanArchitecture.Application.Features.UserFeatures.UpdatePassword;
using CleanArchitecture.Application.Features.UserFeatures.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult> CreateUser([FromBody]CreateUserRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        HttpContext.Response.StatusCode = (int)response.StatusCode;
        return Ok(jsonResponse);
    }
    
    [HttpPost("login")]
    [Produces("application/json")]
    public async Task<ActionResult> Login([FromBody]LoginRequest request,
        CancellationToken cancellationToken)
    {
        var data = request;
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet("{Id}")]
    public async Task<ActionResult> GetUser(int Id, CancellationToken cancellationToken)
    {
        var request = new GetUserRequest{
            userID = Id
        };
        var response = await _mediator.Send(request, cancellationToken);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        HttpContext.Response.StatusCode = (int)response.StatusCode;
        return Ok(jsonResponse);
    }
    [HttpPut("{Id}")]
    public async Task<ActionResult> UpdateUser(int Id,[FromBody]UpdateUserRequest request, CancellationToken cancellationToken)
    {
        request.userId = Id;
        var response = await _mediator.Send(request, cancellationToken);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        HttpContext.Response.StatusCode = (int)response.StatusCode;
        return Ok(jsonResponse);
    }
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteUser(int Id, CancellationToken cancellationToken)
    {
        var request = new DeleteUserRequest{
            userID = Id
        };
        var response = await _mediator.Send(request, cancellationToken);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        HttpContext.Response.StatusCode = (int)response.StatusCode;
        return Ok(jsonResponse);
    }

    
    [HttpPut("{Id}/password")]
    public async Task<ActionResult> UpdatePassword(int Id, UpdatePasswordRequest request,
        CancellationToken cancellationToken)
    {
        request.userID = Id;
        var response = await _mediator.Send(request, cancellationToken);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        HttpContext.Response.StatusCode = (int)response.StatusCode;
        return Ok(jsonResponse);
    }
}