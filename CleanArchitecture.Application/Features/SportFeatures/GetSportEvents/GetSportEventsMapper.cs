using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.GetSportEvents;

public sealed class GetSportEventsMapper : Profile
{
    public GetSportEventsMapper()
    {
        CreateMap<User, GetSportEventsResponse>();
    }
}