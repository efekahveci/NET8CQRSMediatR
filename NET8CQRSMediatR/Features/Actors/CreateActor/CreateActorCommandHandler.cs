using MediatR;
using NET8CQRSMediatR.Data;
using NET8CQRSMediatR.Models;

namespace NET8CQRSMediatR.Features.Actors.CreateActor;

public class CreateActorCommandHandler : IRequestHandler<CreateActorCommand, Guid>
{
    private readonly AppDbContext _context;

    public CreateActorCommandHandler(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Guid> Handle(CreateActorCommand request, CancellationToken cancellationToken)
    {
        var actor = new Actor
        {
            FirstName = request.firstName,
            LastName = request.lastName
        };

        _context.Actors.Add(actor);

        await _context.SaveChangesAsync();

        return actor.ActorId;
    }
}
