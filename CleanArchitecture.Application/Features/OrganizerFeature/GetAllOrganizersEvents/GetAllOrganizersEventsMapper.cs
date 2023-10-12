using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllOrganizers;

public sealed class GetAllOrganizersMapper : Profile
{
    public GetAllOrganizersMapper()
    {
        CreateMap<User, GetAllOrganizersResponse>();
    }
}