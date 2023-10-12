namespace CleanArchitecture.Application.Features.UserFeatures.CreateOrganizer;

public sealed record CreateOrganizerResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}