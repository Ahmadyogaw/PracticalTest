﻿namespace CleanArchitecture.Application.Features.UserFeatures.UpdatePassword;

public sealed record UpdatePasswordResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}