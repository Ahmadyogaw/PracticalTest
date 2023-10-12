using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateOrganizers;

public sealed record UpdateOrganizersRequest : IRequest<UpdateOrganizersResponse>;