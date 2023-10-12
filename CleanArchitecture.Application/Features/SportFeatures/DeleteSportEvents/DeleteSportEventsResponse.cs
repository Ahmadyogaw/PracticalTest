namespace CleanArchitecture.Application.Features.UserFeatures.DeleteSportEvents;

public sealed record DeleteSportEventsResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}