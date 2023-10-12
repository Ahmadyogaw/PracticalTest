using System.Net.Http.Json;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, HttpResponseMessage>
{

    public CreateUserHandler()
    {
    }
    
     public async Task<HttpResponseMessage> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var httpClient = new HttpClient();
        
        var req = JsonContent.Create(request);

        JsonContent content = req;

        HttpResponseMessage response = await httpClient.PostAsync("https://api-sport-events.php9-01.test.voxteneo.com/api/v1/users", content);
        
        return response;
    }

}