namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for team.
    /// </summary>
    public class TeamRequest : Request
    {
        public short Count { get; set; }
        public Competition Competition { get; set; }
        public Season Season { get; set; }
        public Team[] Teams { get; set; }
    }
}
