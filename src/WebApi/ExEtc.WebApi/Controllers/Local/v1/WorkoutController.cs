using ExEtc.Contracts.Local.v1.Workouts.CreateWorkout;
using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.WebApi.Application.Apis;
using Microsoft.AspNetCore.Mvc;

namespace ExEtc.WebApi.Controllers.v3;
[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    //private readonly IStravaApi _stravaApi;
    private readonly ILogger<ActivityController> _logger;

    public WorkoutController(ILogger<ActivityController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "CreateWorkout")]
    public async Task<ActionResult<CreateWorkoutResponse>> Post(CreateWorkoutCommand createWorkoutCommand)
    {
        //var response = await _stravaApi.CreateActivity(createWorkoutCommand);
        return Ok(response);
    }
}
