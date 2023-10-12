namespace CleanArchitecture.Application.Features.UserFeatures.GetOrganizer;

public sealed record GetOrganizerResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}