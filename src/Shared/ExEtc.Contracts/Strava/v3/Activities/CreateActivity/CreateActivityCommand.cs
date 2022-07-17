using System.Text.Json.Serialization;

namespace ExEtc.Contracts.Strava.v3.Activities.CreateActivity;
public record CreateActivityCommand
{
    [JsonPropertyName("name")] public string Name { get; init; }
    [JsonPropertyName("type")] public string Type { get; init; }
    [JsonPropertyName("start_date")] public DateTimeOffset Date { get; init; }
    [JsonPropertyName("elapsed_time")] public int ElapsedTime { get; init; }
    [JsonPropertyName("description")] public string Description { get; init; }
    [JsonPropertyName("distance")] public float Distance { get; init; }
    [JsonPropertyName("trainer")] public int Trainer { get; init; }
    [JsonPropertyName("commute")] public int Commute { get; init; }
    [JsonPropertyName("hide_from_home")] public bool HideFromHome { get; init; }
}