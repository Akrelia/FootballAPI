using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballAPI.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FootballAPI.Models
{
    /// <summary>
    /// Competition data structure.
    /// </summary>
    public class Competition
    {
        public int Id { get; set; }
        public short NumberOfAvailableSeasons { get; set; }
        public Season CurrentSeason { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Plan Plan { get; set; }
        public Area Area { get; set; }
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// String format.
        /// </summary>
        /// <returns>Object in string format.</returns>
        public override string ToString()
        {
            return $"({Name} ({Id}{Code})";
        }
    }
}
