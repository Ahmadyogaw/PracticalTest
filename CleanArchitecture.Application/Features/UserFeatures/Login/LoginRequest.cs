using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.Login;

public sealed record LoginRequest: IRequest<object>
{
    public string email { get; set; }
    public string password { get; set; }

}