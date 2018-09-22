using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Score data structure.
    /// </summary>
    public class Score
    {
        public Winner? Winner { get; set; }
        public Duration? Duration { get; set; }
        public MatchScore FullTime { get; set; }
        public MatchScore HalfTime { get; set; }
        public MatchScore ExtraTime { get; set; }
        public MatchScore Penalties { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"{FullTime}";
        }
    }
}
