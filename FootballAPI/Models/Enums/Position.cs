using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of positions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Position
    {
        Attacker,
        Defender,
        Midfielder,
        Goalkeeper
    }
}
