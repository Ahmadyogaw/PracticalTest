using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteOrganizer;

public sealed class DeleteOrganizerHandler : IRequestHandler<DeleteOrganizerRequest, DeleteOrganizerResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public DeleteOrganizerHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<DeleteOrganizerResponse> Handle(DeleteOrganizerRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek DeleteOrganizerResponse
        List<DeleteOrganizerResponse> users = new();

        // Membuat objek DeleteOrganizerResponse
        var data = new DeleteOrganizerResponse
        {
            Id = 1,
        };

        // Menambahkan objek ke dalam list
        users.Add(data);
        return data;
    }
}