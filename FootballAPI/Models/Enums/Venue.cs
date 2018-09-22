using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of venues.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Venue
    {
        HOME,
        AWAY
    }
}
