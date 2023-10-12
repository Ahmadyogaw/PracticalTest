namespace CleanArchitecture.Application.Features.UserFeatures.UpdateOrganizers;

public sealed record UpdateOrganizersResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}