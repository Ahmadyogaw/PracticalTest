namespace CleanArchitecture.Application.Features.UserFeatures.CreateSportEvents;

public sealed record CreateSportEventsResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}