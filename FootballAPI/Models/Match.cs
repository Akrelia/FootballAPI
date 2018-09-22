using System;
using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Match data structure.
    /// </summary>
    public class Match
    {
        public int Id { get; set; }
        public int Attendance { get; set; }
        public string Venue { get; set; }
        public string Group { get; set; }
        public short? Matchday { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? UTCDate { get; set; }
        public Stage Stage { get; set; }
        public Season Season { get; set; }
        public Competition Competition { get; set; }
        public Score Score { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public Goal[] Goals { get; set; }
        public Referee[] Referees { get; set; }
        public Substitution[] Substitutions { get; set; }
        public Booking[] Bookings { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"({Id}) {HomeTeam} - {AwayTeam} | {UTCDate.Value} ";
        }
    }
}
