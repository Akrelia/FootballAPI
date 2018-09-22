using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {
        PLAYER
    }
}
