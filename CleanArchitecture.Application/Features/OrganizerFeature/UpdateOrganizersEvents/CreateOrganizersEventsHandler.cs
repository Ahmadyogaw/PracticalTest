using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateOrganizers;

public sealed class UpdateOrganizersHandler : IRequestHandler<UpdateOrganizersRequest, UpdateOrganizersResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateOrganizersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<UpdateOrganizersResponse> Handle(UpdateOrganizersRequest request, CancellationToken cancellationToken)
    {
        // Inisialisasi list dengan objek UpdateOrganizersResponse
        List<UpdateOrganizersResponse> users = new();

        // Membuat objek UpdateOrganizersResponse
        var data = new UpdateOrganizersResponse
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