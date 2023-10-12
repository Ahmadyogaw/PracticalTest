using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateSportEvents;

public sealed class UpdateSportEventsMapper : Profile
{
    public UpdateSportEventsMapper()
    {
        CreateMap<User, UpdateSportEventsResponse>();
    }
}