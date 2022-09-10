using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.Contracts.Strava.v3.Athletes.GetAthleteStats;
using ExEtc.WebApi.Application.Apis;
using ExEtc.WebApi.Controllers.v3;
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

    [HttpGet("{id}", Name = "GetAthleteStatsById")]
    public async Task<ActionResult<GetAthleteStatsResponse>> Get(long id)
    {
        var query = new GetAthleteStatsQuery()
        {
            Id = id
        };
        var response = await _stravaApi.GetAthleteStats(query.Id);
        return Ok(response);
    }
}
