namespace CleanArchitecture.Application.Features.UserFeatures.UpdateSportEvents;

public sealed record UpdateSportEventsResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}