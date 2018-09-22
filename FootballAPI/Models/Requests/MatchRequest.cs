namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for match.
    /// </summary>
    public class MatchRequest : Request
    {
        public short Count { get; set; }
        public Competition Competition { get; set; }
        public Match[] Matches { get; set; }
    }
}
