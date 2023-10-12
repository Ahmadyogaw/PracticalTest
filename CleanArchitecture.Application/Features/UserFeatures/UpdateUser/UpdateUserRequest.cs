using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser;

public sealed record UpdateUserRequest : IRequest<HttpResponseMessage>
{
    public int userId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }

}