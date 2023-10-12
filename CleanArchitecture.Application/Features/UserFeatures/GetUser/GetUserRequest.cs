using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetUser;

public sealed record GetUserRequest : IRequest<HttpResponseMessage>
{
    public int userID { get; set; }
};