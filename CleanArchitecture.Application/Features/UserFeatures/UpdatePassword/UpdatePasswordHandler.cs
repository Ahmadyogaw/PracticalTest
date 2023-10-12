using System.Net.Http.Headers;
using System.Net.Http.Json;
using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdatePassword;

public sealed class UpdatePasswordHandler : IRequestHandler<UpdatePasswordRequest, HttpResponseMessage>
{   
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UpdatePasswordHandler(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }
    
    public async Task<HttpResponseMessage> Handle(UpdatePasswordRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        var token = _httpContextAccessor.HttpContext.Request.Headers.Authorization;
        var req = JsonContent.Create(new {
            oldPassword = request.oldPassword,
            newPassword = request.newPassword,
            repeatPassword = request.repeatPassword
        });
        JsonContent content = req;
        httpClient.DefaultRequestHeaders.Add("Authorization", token.ToString());
        HttpResponseMessage response = await httpClient.PutAsync($"https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users/{request.userID}/password", content);
        return response;
    }
}