using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of statuses.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        FINISHED,
        SCHEDULED,
        LIVE,
        IN_PLAY,
        PAUSED,
        POSTPONED,
        SUSPENDED,
        CANCELED
    }
}
