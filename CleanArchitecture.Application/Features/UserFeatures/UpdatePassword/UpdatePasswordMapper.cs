using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdatePassword;

public sealed class UpdatePasswordMapper : Profile
{
    public UpdatePasswordMapper()
    {
        CreateMap<User, UpdatePasswordResponse>();
    }
}