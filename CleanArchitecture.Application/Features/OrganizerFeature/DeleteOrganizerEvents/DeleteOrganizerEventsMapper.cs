using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteOrganizer;

public sealed class DeleteOrganizerMapper : Profile
{
    public DeleteOrganizerMapper()
    {
        CreateMap<User, DeleteOrganizerResponse>();
    }
}