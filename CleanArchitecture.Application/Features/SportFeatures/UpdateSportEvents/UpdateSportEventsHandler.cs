using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateSportEvents;

public sealed class UpdateSportEventsHandler : IRequestHandler<UpdateSportEventsRequest, UpdateSportEventsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UpdateSportEventsHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<UpdateSportEventsResponse> Handle(UpdateSportEventsRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek UpdateSportEventsResponse
        List<UpdateSportEventsResponse> users = new();

        // Membuat objek UpdateSportEventsResponse
        var data = new UpdateSportEventsResponse
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