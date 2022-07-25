using ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
using Refit;

namespace ExEtc.WebApi.Application.Apis;

public interface IStravaApi
{
    [Post("/v3/activities")]
    Task<CreateActivityResponse> CreateActivity(CreateActivityCommand command);
}
