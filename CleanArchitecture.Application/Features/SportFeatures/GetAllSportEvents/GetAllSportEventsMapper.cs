using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllSportEvents;

public sealed class GetAllSportEventsMapper : Profile
{
    public GetAllSportEventsMapper()
    {
        CreateMap<User, GetAllSportEventsResponse>();
    }
}