using System.Text.Json.Serialization;

namespace ExEtc.Contracts.Strava.v3.Models;
public record DetailedActivity
{
    [JsonPropertyName("id")] public long Id { get; init; }
    [JsonPropertyName("external_id")] public string ExternalId { get; init; }
    [JsonPropertyName("upload_id")] public long UploadId { get; init; }
    [JsonPropertyName("athlete")] public MetaAthlete Athlete { get; init; }
    [JsonPropertyName("name")] public string Name { get; init; }
    [JsonPropertyName("distance")] public float Distance { get; init; }
    [JsonPropertyName("moving_time")] public int MovingTime { get; init; }
    [JsonPropertyName("elapsed_time")] public int ElapsedTime { get; init; }
    [JsonPropertyName("total_elevation_gain")] public float TotalElevationGain { get; init; }
    [JsonPropertyName("elev_high")] public float ElevHigh { get; init; }
    [JsonPropertyName("elev_low")] public float ElevLow { get; init; }
    [JsonPropertyName("type")] public ActivityType Type { get; set; }
    [JsonPropertyName("start_date")] public DateTimeOffset StartDate { get; set; }
    [JsonPropertyName("start_date_local")] public DateTimeOffset StartDateLocal { get; set; }
    [JsonPropertyName("timezone")] public string Timezone { get; init; }
    [JsonPropertyName("start_latlng")] public LatLng StartLatlng {get; init;}
    [JsonPropertyName("end_latlng")] public LatLng EndLatlng {get; init;}
    [JsonPropertyName("achievement_count")] public int AchievementCount {get; init;}
    [JsonPropertyName("kudos_count")] public int KudosCount {get; init;}
    [JsonPropertyName("comment_count")] public int CommentCount {get; init;}
    [JsonPropertyName("athlete_count")] public int AthleteCount {get; init;}
    [JsonPropertyName("photo_count")] public int PhotoCount {get; init;}
    [JsonPropertyName("total_photo_count")] public int TotoalPhotoCount {get; init;}
    [JsonPropertyName("map")] public PolylineMap Map {get; init;}
    [JsonPropertyName("trainer")] public bool Trainer {get; init;}
    [JsonPropertyName("commute")] public bool Commute {get; init;}
    [JsonPropertyName("manual")] public bool Manual {get; init;}
    [JsonPropertyName("private")] public bool Private {get; init;}
    [JsonPropertyName("flagged")] public bool Flagged {get; init;}
    [JsonPropertyName("workout_type")] public int WorkoutType {get; init;}
    [JsonPropertyName("upload_id_str")] public string UploadIdStr {get; init;}
    [JsonPropertyName("average_speed")] public float AverageSpeed {get; init;}
    [JsonPropertyName("max_speed")] public float MaxSpeed {get; init;}
    [JsonPropertyName("has_kudoed")] public bool HasKudoed {get; init;}
    [JsonPropertyName("hide_from_home")] public bool HideFromHome {get; init;}
    [JsonPropertyName("gear_id")] public string GearId {get; init;}
    [JsonPropertyName("kilojoules")] public float Kilojoules {get; init;}
    [JsonPropertyName("average_watts")] public float AverageWatts {get; init;}
    [JsonPropertyName("device_watts")] public bool DeviceWatts {get; init;}
    [JsonPropertyName("max_watts")] public int MaxWatts {get; init;}
    [JsonPropertyName("weighted_average_watts")] public int WeightedAverageWatts {get; init;}
    [JsonPropertyName("description")] public string Description {get; init;}
    [JsonPropertyName("photos")] public PhotosSummary Photos {get; init;}
    [JsonPropertyName("gear")] public SummaryGear Gear {get; init;}
    [JsonPropertyName("calories")] public float Calories {get; init;}
    [JsonPropertyName("segment_efforts")] public DetailedSegmentEffort[] SegmentEfforts {get; init;}
    [JsonPropertyName("device_name")] public string DeviceName {get; init;}
    [JsonPropertyName("embed_token")] public string EmbedToken {get; init;}
    [JsonPropertyName("splits_metric")] public Split SplitsMetric {get; init;}
    [JsonPropertyName("splits_standard")] public Split SplitsStandard {get; init;}
    [JsonPropertyName("laps")] public Lap[] Laps {get; init;}
    [JsonPropertyName("best_efforts")] public DetailedSegmentEffort[] BestEfforts { get; init; }


}
