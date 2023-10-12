using System.Net.Http.Headers;
using System.Net.Http.Json;
using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed class DeleteUserHandler : IRequestHandler<DeleteUserRequest, HttpResponseMessage>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public DeleteUserHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<HttpResponseMessage> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek DeleteUserResponse
        var httpClient = new HttpClient();
        httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczpcL1wvYXBpLXNwb3J0LWV2ZW50cy5waHA5LTAxLnRlc3Qudm94dGVuZW8uY29tXC9hcGlcL3YxXC91c2Vyc1wvbG9naW4iLCJpYXQiOjE2OTcwMjQ5ODYsImV4cCI6MTY5NzExMTM4NiwibmJmIjoxNjk3MDI0OTg2LCJqdGkiOiJEMFFSUHcxYUFrYndsZkRsIiwic3ViIjoyODc5LCJwcnYiOiI4N2UwYWYxZWY5ZmQxNTgxMmZkZWM5NzE1M2ExNGUwYjA0NzU0NmFhIn0.ttx2N4ynuDjT9qw2JiwbaDx_kViVCl4yOg98TDwY6GQ");
        var req = JsonContent.Create(request);

        JsonContent content = req;

        HttpResponseMessage response = await httpClient.DeleteAsync($"https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users/{request.userID}", cancellationToken);
       
        return response;
    }
}