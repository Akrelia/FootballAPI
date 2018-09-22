using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models.Enums
{
    /// <summary>
    /// List of cards.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Card
    {
        YELLOW_CARD,
        RED_CARD
    }
}
