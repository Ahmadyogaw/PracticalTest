using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateSportEvents;

public sealed record UpdateSportEventsRequest : IRequest<UpdateSportEventsResponse>;