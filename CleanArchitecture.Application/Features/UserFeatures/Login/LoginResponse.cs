namespace CleanArchitecture.Application.Features.UserFeatures.Login;

public sealed record LoginResponse
{
    public HttpResponseMessage data {get ; set;}
}