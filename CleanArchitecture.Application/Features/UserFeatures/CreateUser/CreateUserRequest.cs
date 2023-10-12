using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed record CreateUserRequest : IRequest<HttpResponseMessage>
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string repeatPassword { get; set; }
}