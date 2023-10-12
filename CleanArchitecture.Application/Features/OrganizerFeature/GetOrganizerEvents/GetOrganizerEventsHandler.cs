using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetOrganizer;

public sealed class GetOrganizerHandler : IRequestHandler<GetOrganizerRequest, GetOrganizerResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetOrganizerHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<GetOrganizerResponse> Handle(GetOrganizerRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek GetOrganizerResponse
        List<GetOrganizerResponse> users = new();

        // Membuat objek GetOrganizerResponse
        var data = new GetOrganizerResponse
        {
            Id = 1,
            Email = "ahmad",
            Name = "yoga"
        };

        // Menambahkan objek ke dalam list
        users.Add(data);
        return data;
    }
}