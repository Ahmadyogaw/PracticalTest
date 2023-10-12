using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetSportEvents;

public sealed class GetSportEventsHandler : IRequestHandler<GetSportEventsRequest, GetSportEventsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public GetSportEventsHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<GetSportEventsResponse> Handle(GetSportEventsRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek GetSportEventsResponse
        List<GetSportEventsResponse> users = new();

        // Membuat objek GetSportEventsResponse
        var data = new GetSportEventsResponse
        {
            Id = 1,
        };

        // Menambahkan objek ke dalam list
        users.Add(data);
        return data;
    }
}