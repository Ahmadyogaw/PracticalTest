using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdatePassword;

public sealed record UpdatePasswordRequest : IRequest<HttpResponseMessage>
{
    public int userID { get; set; }
    public string oldPassword { get; set; }
    public string newPassword { get; set; }
    public string repeatPassword { get; set; }
};