using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.WebApi.Application.Apis;
using Microsoft.AspNetCore.Mvc;

namespace ExEtc.WebApi.Controllers.v3;
[ApiController]
[Route("[controller]")]
public class ActivityController : ControllerBase
{
    private readonly IStravaApi _stravaApi;
    private readonly ILogger<ActivityController> _logger;

    public ActivityController(ILogger<ActivityController> logger, IStravaApi stravaApi)
    {
        _logger = logger;
        _stravaApi = stravaApi;
    }

    [HttpPost(Name = "CreateActivity")]
    public async Task<ActionResult<CreateActivityResponse>> Post(CreateActivityCommand createActivityCommand)
    {
        var response = await _stravaApi.CreateActivity(createActivityCommand);
        return Ok(response);
    }
}
