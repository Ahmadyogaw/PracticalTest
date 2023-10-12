namespace CleanArchitecture.Application.Features.UserFeatures.DeleteOrganizer;

public sealed record DeleteOrganizerResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}