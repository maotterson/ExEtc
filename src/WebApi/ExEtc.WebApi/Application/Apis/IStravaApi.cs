using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using ExEtc.Contracts.Strava.v3.Athletes.GetAthleteStats;
using Refit;

namespace ExEtc.WebApi.Application.Apis;

public interface IStravaApi
{
    [Post("/v3/activities")]
    Task<CreateActivityResponse> CreateActivity(CreateActivityCommand command);
    [Get("/v3/athletes/{id}/stats")]
    Task<GetAthleteStatsResponse> GetAthleteStats(string id);
}
