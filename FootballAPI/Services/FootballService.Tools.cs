using System.Text;
using FootballAPI.Models;

namespace FootballAPI.Services
{
    /// <summary>
    /// Tools for the service.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Build the filter for competitions.
        /// </summary>
        /// <param name="competitions">Array of competitions to use as a filter.</param>
        /// <returns>String built.</returns>
        private string BuildCompetitionFilter(Competition[] competitions)
        {
            StringBuilder builder = new StringBuilder();
            string delimiter = "";

            foreach (Competition competition in competitions)
            {
                builder.Append(delimiter);
                builder.Append(competition.Code);
                delimiter = ",";
            }

            return builder.ToString();
        }
    }
}
