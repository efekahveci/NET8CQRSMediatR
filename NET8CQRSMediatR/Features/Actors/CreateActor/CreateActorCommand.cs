using MediatR;

namespace NET8CQRSMediatR.Features.Actors.CreateActor;

public record CreateActorCommand(string firstName, string lastName) : IRequest<Guid>;
