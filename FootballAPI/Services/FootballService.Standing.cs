using FootballAPI.Models;
using FootballAPI.Models.Requests;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with standing requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Get all standings of a competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <returns>List of the standings for the specific competition.</returns>
        public StandingRequest GetStandings(int competition)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/standings";

            return ExecuteRequest<StandingRequest>(url);
        }

        /// <summary>
        /// Get all standings of a competition.
        /// </summary>
        /// <param name="competition">Code of the competition.</param>
        /// <returns>List of the standings for the specific competition.</returns>
        public StandingRequest GetStandings(string competition)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/standings";

            return ExecuteRequest<StandingRequest>(url);
        }

        /// <summary>
        /// Get all standings of a competition.
        /// </summary>
        /// <param name="competition">Competition.</param>
        /// <returns>List of the standings for the specific competition.</returns>
        public StandingRequest GetStandings(Competition competition)
        {
            return GetStandings(competition.Id);
        }
    }
}
