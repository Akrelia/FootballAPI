namespace FootballAPI.Models
{
    /// <summary>
    /// Referee data structure.
    /// </summary>
    public class Referee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }

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
