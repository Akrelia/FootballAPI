using System;

namespace FootballAPI.Models
{
    /// <summary>
    /// Team data structure.
    /// </summary>
    public class Team
    {
        public short Id { get; set; }
        public short Found { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string TLA { get; set; }
        public string CrestURL { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string ClubColors { get; set; }
        public string Venue { get; set; }
        public DateTime? LastUpdated { get; set; }
        public Area Area { get; set; }
        public Player Coach { get; set; }
        public Player[] Squad { get; set; }
        public Player[] Lineup { get; set; }
        public Player[] Bench { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
