using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of stages.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Stage
    {
        [EnumMember(Value = "1ST_QUALIFYING_ROUND")]
        FIRST_QUALIFYING_ROUND,
        [EnumMember(Value = "2ND_QUALIFYING_ROUND")]
        SECOND_QUALIFYING_ROUND,
        [EnumMember(Value = "3RD_QUALIFYING_ROUND")]
        THIRD_QUALIFYING_ROUND,
        [EnumMember(Value = "3RD_PLACE")]
        THIRD_PLACE,
        PLAY_OFF_ROUND,
        REGULAR_SEASON,
        GROUP_STAGE,
        ROUND_OF_16,
        QUARTER_FINALS,
        SEMI_FINALS,
        FINAL
    }
}
