using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of durations.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Duration
    {
        REGULAR,
        EXTRA_TIME,
        PENALTY_SHOOTOUT
    }
}
