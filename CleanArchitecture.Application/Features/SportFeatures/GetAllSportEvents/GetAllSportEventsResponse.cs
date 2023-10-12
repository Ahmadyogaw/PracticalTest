namespace CleanArchitecture.Application.Features.UserFeatures.GetAllSportEvents;

public sealed record GetAllSportEventsResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}