using System.Text.Json.Serialization;

namespace ExEtc.Contracts.Strava.v3.Models;
public record Fault
{
    [JsonPropertyName("errors")] public Error[] Errors { get; init; }
    [JsonPropertyName("message")] public string Message { get; init; }
}
