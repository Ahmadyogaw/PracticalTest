using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetOrganizer;

public sealed record GetOrganizerRequest : IRequest<GetOrganizerResponse>;