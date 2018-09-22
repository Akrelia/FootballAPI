namespace FootballAPI.Models
{
    /// <summary>
    /// Table data structure.
    /// </summary>
    public class Table
    {
        public short Position { get; set; }
        public short PlayedGames { get; set; }
        public short Won { get; set; }
        public short Points { get; set; }
        public short Draw { get; set; }
        public short Lost { get; set; }
        public short GoalsFor { get; set; }
        public short GoalsAgainst { get; set; }
        public short GoalDifference { get; set; }
        public Team Team { get; set; }
    }
}
