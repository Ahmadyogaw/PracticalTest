using System.Net.Http.Headers;
using AutoMapper;
using MediatR;
using CleanArchitecture.Application.Repositories;
using System.Net.Http.Json;
using System.Text.Json;

namespace CleanArchitecture.Application.Features.UserFeatures.Login;

public sealed class LoginHandler : IRequestHandler<LoginRequest, object>
{
    private readonly IMapper _mapper;

    public LoginHandler(IUserRepository userRepository, IMapper mapper)
    {
        _mapper = mapper;
    }
    
    public async Task<object> Handle(LoginRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBpLXNwb3J0LWV2ZW50cy5waHA5LTAxLnRlc3Qudm94dGVuZW8uY29tXC9hcGlcL3YxXC91c2Vyc1wvbG9naW4iLCJpYXQiOjE2OTcwMjQ5ODYsImV4cCI6MTY5NzExMTM4NiwibmJmIjoxNjk3MDI0OTg2LCJqdGkiOiJEMFFSUHcxYUFrYndsZkRsIiwic3ViIjoyODc5LCJwcnYiOiI4N2UwYWYxZWY5ZmQxNTgxMmZkZWM5NzE1M2ExNGUwYjA0NzU0NmFhIn0.ttx2N4ynuDjT9qw2JiwbaDx_kViVCl4yOg98TDwY6GQ");
        var req = JsonContent.Create(request);

        JsonContent content = req;

        HttpResponseMessage response = await httpClient.PostAsync("https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users/login", content);
        string responseContent = await response.Content.ReadAsStringAsync();
        dynamic jsonResponse = JsonSerializer.Deserialize<dynamic>(responseContent);
        return jsonResponse;
    
    }
}