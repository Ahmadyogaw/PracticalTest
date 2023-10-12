using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllSportEvents;

public sealed record GetAllSportEventsRequest : IRequest<GetAllSportEventsResponse>;