using ExEtc.Contracts.Local.v1.Workouts.CreateWorkout;
using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.WebApi.Application.Apis;
using ExEtc.WebApi.Application.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ExEtc.WebApi.Controllers.v3;
[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<ActivityController> _logger;

    public WorkoutController(ILogger<ActivityController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CreateWorkout")]
    public async Task<ActionResult<CreateWorkoutResponse>> Post(CreateWorkoutCommand createWorkoutCommand)
    {
        var response = await _mediator.Send(createWorkoutCommand) ?? throw new NullReferenceException(); // todo
        return Ok(response);
    }
}
