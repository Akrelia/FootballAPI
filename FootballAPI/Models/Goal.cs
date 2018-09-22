using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Goal data structure.
    /// </summary>
    public class Goal
    {
        public short Minute { get; set; }
        public short ExtraTime { get; set; }
        public GoalType Type { get; set; }
        public Team Team { get; set; }
        public Player Scorer { get; set; }
        public Player Assist { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"{Scorer.Name} ({Minute})";
        }
    }
}
