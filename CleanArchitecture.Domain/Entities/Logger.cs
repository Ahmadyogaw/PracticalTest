using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public sealed class Logger : BaseEntity
{
    public string Method { get; set; }
    public string Request { get; set; }
    public string Response { get; set; }
    public string Path { get; set; }
}