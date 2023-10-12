using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateOrganizer;

public sealed record CreateOrganizerRequest : IRequest<CreateOrganizerResponse>;