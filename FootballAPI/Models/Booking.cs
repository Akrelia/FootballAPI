using FootballAPI.Models.Enums;

namespace FootballAPI.Models
{
    /// <summary>
    /// Booking data structure.
    /// </summary>
    public class Booking
    {
        public short Minute { get; set; }
        public Team Team { get; set; }
        public Player Player { get; set; }
        public Card Card { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"{Player.Name} : {Card} ({Minute})";
        }
    }
}
