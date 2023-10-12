using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllOrganizers;

public sealed record GetAllOrganizersRequest : IRequest<GetAllOrganizersResponse>;