namespace FootballAPI.Models
{
    /// <summary>
    /// Substitution data structure.
    /// </summary>
    public class Substitution
    {
        public short Minute { get; set; }
        public Team Team { get; set; }
        public Player PlayerOut { get; set; }
        public Player PlayerIn { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"IN:{PlayerIn} (OUT:{PlayerOut})";
        }
    }
}
