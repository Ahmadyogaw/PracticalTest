using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteSportEvents;

public sealed class DeleteSportEventsMapper : Profile
{
    public DeleteSportEventsMapper()
    {
        CreateMap<User, DeleteSportEventsResponse>();
    }
}