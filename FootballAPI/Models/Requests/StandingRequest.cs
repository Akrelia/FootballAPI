namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for standing.
    /// </summary>
    public class StandingRequest : Request
    {
        public Season Season { get; set; }
        public Competition Competition { get; set; }
        public Standing[] Standings { get; set; }
    }
}
