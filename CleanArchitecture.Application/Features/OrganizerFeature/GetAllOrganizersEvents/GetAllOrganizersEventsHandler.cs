using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllOrganizers;

public sealed class GetAllOrganizersHandler : IRequestHandler<GetAllOrganizersRequest, GetAllOrganizersResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllOrganizersHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<GetAllOrganizersResponse> Handle(GetAllOrganizersRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek GetAllOrganizersResponse
        List<GetAllOrganizersResponse> users = new();

        // Membuat objek GetAllOrganizersResponse
        var data = new GetAllOrganizersResponse
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