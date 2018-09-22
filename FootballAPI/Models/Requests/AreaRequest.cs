namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request for area.
    /// </summary>
    public class AreaRequest : Request
    {
        public short Count { get; set; }
        public Area[] Area { get; set; }
    }
}
