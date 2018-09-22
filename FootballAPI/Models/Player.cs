using System;
using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Player data structure.
    /// </summary>
    public class Player
    {
        public int Id { get; set; }
        public int? ShirtNumber { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryOfBirth { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Position? Position { get; set; }
        public Role? Role { get; set; }

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
