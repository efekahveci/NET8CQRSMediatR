using MediatR;
using Microsoft.AspNetCore.Mvc;
using NET8CQRSMediatR.Features.Actors.CreateActor;
using NET8CQRSMediatR.Features.Actors.GetActorById;

namespace NET8CQRSMediatR.Controllers;

[ApiController]
[Route("[controller]")]
public class ActorController(ILogger<ActorController> logger, ISender sender) : ControllerBase
{

    private readonly ILogger<ActorController> _logger = logger;
    private readonly ISender _sender = sender;

    [HttpGet("{id}", Name = "GetActor")]
    public IActionResult Get(Guid id)
    {
        var result = _sender.Send(new GetActorByIdQuery(id));

        return Ok(result);
    }

    [HttpPost(Name = "CreateActor")]
    public async Task<IActionResult> Post([FromBody] CreateActorCommand actor)
    {
        var result = await _sender.Send(actor);

        return Ok(result);
    }
}
