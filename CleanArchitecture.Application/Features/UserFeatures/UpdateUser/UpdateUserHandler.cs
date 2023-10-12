using System.Net.Http.Json;
using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser;

public sealed class UpdateUserHandler : IRequestHandler<UpdateUserRequest, HttpResponseMessage>
{
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UpdateUserHandler(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor )
    {
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper;
    }
    
    public async Task<HttpResponseMessage> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        var req = JsonContent.Create(new {
            firstName = request.firstName,
            lastName = request.lastName,
            email = request.email
        });
        
        JsonContent content = req;

        var token = _httpContextAccessor.HttpContext.Request.Headers.Authorization;
        httpClient.DefaultRequestHeaders.Add("Authorization", token.ToString());

        HttpResponseMessage response = await httpClient.PutAsync($"https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users/{request.userId}", content);
        
        return response;
    }
}