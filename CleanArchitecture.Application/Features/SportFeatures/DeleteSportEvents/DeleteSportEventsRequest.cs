using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteSportEvents;

public sealed record DeleteSportEventsRequest : IRequest<DeleteSportEventsResponse>;