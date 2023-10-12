using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteOrganizer;

public sealed record DeleteOrganizerRequest : IRequest<DeleteOrganizerResponse>;