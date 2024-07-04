using MediatR;
using NET8CQRSMediatR.Models;

namespace NET8CQRSMediatR.Features.Actors.GetActorById;

public record GetActorByIdQuery(Guid Guid) : IRequest<Actor>;