using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateSportEvents;

public sealed class CreateSportEventsHandler : IRequestHandler<CreateSportEventsRequest, CreateSportEventsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateSportEventsHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<CreateSportEventsResponse> Handle(CreateSportEventsRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek CreateSportEventsResponse
        List<CreateSportEventsResponse> users = new();

        // Membuat objek CreateSportEventsResponse
        var data = new CreateSportEventsResponse
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