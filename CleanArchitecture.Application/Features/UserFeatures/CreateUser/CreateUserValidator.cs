using FluentValidation;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserValidator : AbstractValidator<HttpResponseMessage>
{
    public CreateUserValidator()
    {
    }
}