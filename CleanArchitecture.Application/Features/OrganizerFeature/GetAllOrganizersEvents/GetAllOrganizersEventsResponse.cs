namespace CleanArchitecture.Application.Features.UserFeatures.GetAllOrganizers;

public sealed record GetAllOrganizersResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}