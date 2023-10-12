using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllSportEvents;

public sealed class GetAllSportEventsHandler : IRequestHandler<GetAllSportEventsRequest, GetAllSportEventsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetAllSportEventsHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<GetAllSportEventsResponse> Handle(GetAllSportEventsRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek GetAllSportEventsResponse
        List<GetAllSportEventsResponse> users = new();

        // Membuat objek GetAllSportEventsResponse
        var data = new GetAllSportEventsResponse
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