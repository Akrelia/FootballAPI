using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Standing data structure.
    /// </summary>
    public class Standing
    {
        public string Group { get; set; }
        public Stage? Stage { get; set; }
        public StandingType? Type { get; set; }
        public Table[] Table { get; set; }
    }
}
