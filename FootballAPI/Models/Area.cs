namespace FootballAPI.Models
{
    /// <summary>
    /// Area data structure.
    /// </summary>
    public class Area
    {
        public int? Id { get; set; }
        public string Name { get; set; }

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
