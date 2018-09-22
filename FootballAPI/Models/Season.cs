using System;

namespace FootballAPI.Models
{
    /// <summary>
    /// Season data structure.
    /// </summary>
    public class Season
    {
        public short Id { get; set; }
        public short? CurrentMatchday { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
