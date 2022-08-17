using System.Text.Json.Serialization;

namespace ExEtc.Contracts.Strava.v3.Models;
public record ActivityStats
{
    [JsonPropertyName("biggest_ride_distance")] public double? BiggestRideDistance { get; set; }
    [JsonPropertyName("biggest_climb_elevation_gain")] public double? BiggestClimbElevationGain { get; set; }
    [JsonPropertyName("recent_ride_totals")] public ActivityTotal? RecentRideTotals { get; set; }
    [JsonPropertyName("recent_run_totals")] public ActivityTotal? RecentRunTotals { get; set; }
    [JsonPropertyName("recent_swim_totals")] public ActivityTotal? RecentSwimTotals { get; set; }
    [JsonPropertyName("ytd_ride_totals")] public ActivityTotal? YtdRideTotals { get; set; }
    [JsonPropertyName("ytd_run_totals")] public ActivityTotal? YtdRunTotals { get; set; }
    [JsonPropertyName("ytd_swim_totals")] public ActivityTotal? YtdSwimTotals { get; set; }
    [JsonPropertyName("all_ride_totals")] public ActivityTotal? AllRideTotals { get; set; }
    [JsonPropertyName("all_run_totals")] public ActivityTotal? AllRunTotals { get; set; }
    [JsonPropertyName("all_swim_totals")] public ActivityTotal? AllSwimTotals { get; set; }
}