namespace FootballAPI.Models
{
    /// <summary>
    /// Match score data structure.
    /// </summary>
    public class MatchScore
    {
        public short? HomeTeam { get; set; }
        public short? AwayTeam { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"{HomeTeam}-{AwayTeam}";
        }
    }
}
