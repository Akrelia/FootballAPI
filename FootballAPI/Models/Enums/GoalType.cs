using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of goal types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GoalType
    {
        REGULAR,
        OWN_GOAL
    }
}
