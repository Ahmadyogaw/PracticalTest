using System.Net.Http.Headers;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Application.Features.UserFeatures.GetUser;

public sealed class GetUserHandler : IRequestHandler<GetUserRequest, HttpResponseMessage>
{
    // private readonly  _mapper;
    
    public readonly IHttpContextAccessor _httpContextAccessor;
    public GetUserHandler( IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public async Task<HttpResponseMessage> Handle(GetUserRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        var token = _httpContextAccessor.HttpContext.Request.Headers.Authorization;

        httpClient.DefaultRequestHeaders.Add("Authorization", token.ToString() );
        var req = System.Net.Http.Json.JsonContent.Create(request);

        System.Net.Http.Json.JsonContent content = req;

        HttpResponseMessage response = await httpClient.GetAsync($"https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users/{request.userID}");
        
        return response;
    }
}