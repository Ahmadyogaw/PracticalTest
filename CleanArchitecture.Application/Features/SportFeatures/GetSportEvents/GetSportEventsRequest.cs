using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetSportEvents;

public sealed record GetSportEventsRequest : IRequest<GetSportEventsResponse>;