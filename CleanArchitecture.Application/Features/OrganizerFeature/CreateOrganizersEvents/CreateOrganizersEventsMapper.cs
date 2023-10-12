using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateOrganizer;

public sealed class CreateOrganizerMapper : Profile
{
    public CreateOrganizerMapper()
    {
        CreateMap<User, CreateOrganizerResponse>();
    }
}