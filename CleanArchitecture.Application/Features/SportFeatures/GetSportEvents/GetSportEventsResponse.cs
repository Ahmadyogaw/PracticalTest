namespace CleanArchitecture.Application.Features.UserFeatures.GetSportEvents;

public sealed record GetSportEventsResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}