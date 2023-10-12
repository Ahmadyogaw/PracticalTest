using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateSportEvents;

public sealed record CreateSportEventsRequest : IRequest<CreateSportEventsResponse>;