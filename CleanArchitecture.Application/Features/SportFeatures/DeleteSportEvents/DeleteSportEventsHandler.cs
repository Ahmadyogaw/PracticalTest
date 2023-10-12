using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteSportEvents;

public sealed class DeleteSportEventsHandler : IRequestHandler<DeleteSportEventsRequest, DeleteSportEventsResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public DeleteSportEventsHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    public async Task<DeleteSportEventsResponse> Handle(DeleteSportEventsRequest request, CancellationToken cancellationToken)
    {
                // Inisialisasi list dengan objek DeleteSportEventsResponse
        List<DeleteSportEventsResponse> users = new();

        // Membuat objek DeleteSportEventsResponse
        var data = new DeleteSportEventsResponse
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