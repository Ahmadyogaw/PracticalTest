using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateOrganizer;

public sealed class CreateOrganizerHandler : IRequestHandler<CreateOrganizerRequest, CreateOrganizerResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateOrganizerHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<CreateOrganizerResponse> Handle(CreateOrganizerRequest request, CancellationToken cancellationToken)
    {
        // Inisialisasi list dengan objek CreateOrganizerResponse
        List<CreateOrganizerResponse> users = new();

        // Membuat objek CreateOrganizerResponse
        var data = new CreateOrganizerResponse
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