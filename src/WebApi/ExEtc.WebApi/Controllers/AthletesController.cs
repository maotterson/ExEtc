using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.Contracts.Strava.v3.Athletes.GetAthleteStats;
using ExEtc.WebApi.Application.Apis;
using Microsoft.AspNetCore.Mvc;

namespace ExEtc.WebApi.Controllers;
[ApiController]
[Route("[controller]")]
public class AthletesController : ControllerBase
{
    private readonly IStravaApi _stravaApi;
    private readonly ILogger<ActivityController> _logger;

    public AthletesController(ILogger<ActivityController> logger, IStravaApi stravaApi)
    {
        _logger = logger;
        _stravaApi = stravaApi;
    }

    [HttpPost(Name = "GetAthleteStats")]
    public async Task<ActionResult<GetAthleteStatsResponse>> Get(GetAthleteStatsQuery getAthleteStatsQuery)
    {
        var response = await _stravaApi.GetAthleteStats(getAthleteStatsQuery.Id);
        return Ok(response);
    }
}
