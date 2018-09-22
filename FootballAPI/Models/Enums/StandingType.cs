using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of standing types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StandingType
    {
        TOTAL,
        HOME,
        AWAY
    }
}
