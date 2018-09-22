namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for competition.
    /// </summary>
    public class CompetitionRequest : Request
    {
        public short Count { get; set; }
        public Competition[] Competitions { get; set; }
    }
}
