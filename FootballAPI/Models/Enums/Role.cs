using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of roles.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {
        PLAYER,
        COACH,
        ASSISTANT_COACH,
        INTERIM_COACH
    }
}
