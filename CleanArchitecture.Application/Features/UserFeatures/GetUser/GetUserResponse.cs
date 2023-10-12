namespace CleanArchitecture.Application.Features.UserFeatures.GetUser;

public sealed record GetUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}