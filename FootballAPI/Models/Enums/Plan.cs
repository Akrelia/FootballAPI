using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of plans..
    /// </summary>
    /// <remarks>Visit https://www.football-data.org/pricing for more informations about plans / tiers.</remarks>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Plan
    {
        TIER_ONE,
        TIER_TWO,
        TIER_THREE,
        TIER_FOUR
    }
}
