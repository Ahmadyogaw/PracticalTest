using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateOrganizers;

public sealed class UpdateOrganizersMapper : Profile
{
    public UpdateOrganizersMapper()
    {
        CreateMap<User, UpdateOrganizersResponse>();
    }
}