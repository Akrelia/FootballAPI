namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for player.
    /// </summary>
    public class PlayerRequest : Request
    {
        public Player Player { get; set; }
    }
}
