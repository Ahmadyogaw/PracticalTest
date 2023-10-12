using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateSportEvents;

public sealed class CreateSportEventsMapper : Profile
{
    public CreateSportEventsMapper()
    {
        CreateMap<User, CreateSportEventsResponse>();
    }
}