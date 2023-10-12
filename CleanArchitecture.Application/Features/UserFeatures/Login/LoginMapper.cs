using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.Login;

public sealed class LoginMapper : Profile
{
    public LoginMapper()
    {
        CreateMap<User, LoginResponse>();
    }
}