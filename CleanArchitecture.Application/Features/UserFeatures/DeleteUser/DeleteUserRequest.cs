using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed record DeleteUserRequest : IRequest<HttpResponseMessage>
{
    public int userID { get; set; }
}