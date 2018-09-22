using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of winners.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Winner
    {
        HOME_TEAM,
        AWAY_TEAM,
        DRAW
    }
}
