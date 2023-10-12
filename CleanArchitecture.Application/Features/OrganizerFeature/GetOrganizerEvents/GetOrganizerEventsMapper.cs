using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.GetOrganizer;

public sealed class GetOrganizerMapper : Profile
{
    public GetOrganizerMapper()
    {
        CreateMap<User, GetOrganizerResponse>();
    }
}