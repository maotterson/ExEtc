using System.Text.Json.Serialization;

namespace ExEtc.Contracts.Strava.v3.Models;
public record ActivityStats
{
    [JsonPropertyName("biggest_ride_distance")] public double BiggestRideDistance { get; set; }
    [JsonPropertyName("biggest_climb_elevation_gain")] public double BiggestClimbElevationGain { get; set; }
    [JsonPropertyName("recent_ride_totals")] public ActivityTotal RecentRideTotals { get; set; }
    [JsonPropertyName("recent_run_totals")] public ActivityTotal RecentRunTotals { get; set; }
    [JsonPropertyName("recent_swim_totals")] public ActivityTotal RecentSwimTotals { get; set; }
    [JsonPropertyName("ytd_ride_totals")] public ActivityTotal YtdRideTotals { get; set; }
    [JsonPropertyName("ytd_run_totals")] public ActivityTotal YtdRunTotals { get; set; }
    [JsonPropertyName("ytd_swim_totals")] public ActivityTotal YtdSwimTotals { get; set; }
    [JsonPropertyName("all_ride_totals")] public ActivityTotal AllRideTotals { get; set; }
    [JsonPropertyName("all_run_totals")] public ActivityTotal AllRunTotals { get; set; }
    [JsonPropertyName("all_swim_totals")] public ActivityTotal AllSwimTotals { get; set; }
}

/*
 * biggest_ride_distance
biggest_climb_elevation_gain
double 	The highest climb ridden by the athlete.
recent_ride_totals
ActivityTotal 	The recent (last 4 weeks) ride stats for the athlete.
recent_run_totals
ActivityTotal 	The recent (last 4 weeks) run stats for the athlete.
recent_swim_totals
ActivityTotal 	The recent (last 4 weeks) swim stats for the athlete.
ytd_ride_totals
ActivityTotal 	The year to date ride stats for the athlete.
ytd_run_totals
ActivityTotal 	The year to date run stats for the athlete.
ytd_swim_totals
ActivityTotal 	The year to date swim stats for the athlete.
all_ride_totals
ActivityTotal 	The all time ride stats for the athlete.
all_run_totals
ActivityTotal 	The all time run stats for the athlete.
all_swim_totals
ActivityTotal 	The all time swim stats for the athlete. 
*/