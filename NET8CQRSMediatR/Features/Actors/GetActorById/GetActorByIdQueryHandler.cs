using MediatR;
using NET8CQRSMediatR.Data;
using NET8CQRSMediatR.Models;

namespace NET8CQRSMediatR.Features.Actors.GetActorById
{
    public class GetActorByIdQueryHandler : IRequestHandler<GetActorByIdQuery, Actor?>
    {
        private readonly AppDbContext _context;
        public GetActorByIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Actor?> Handle(GetActorByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Actors.FindAsync(request.Guid);

            return result;
        }
    }
}
