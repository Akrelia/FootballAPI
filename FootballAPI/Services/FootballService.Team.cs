using FootballAPI.Models.Enums;
using FootballAPI.Models.Requests;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with team requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Get a specific team.
        /// </summary>
        /// <param name="id">Id of the team.</param>
        /// <returns>Team.</returns>
        public TeamRequest GetTeam(int id)
        {
            string url = $"http://api.football-data.org/v2/teams/{id}";

            return ExecuteRequest<TeamRequest>(url);
        }

        /// <summary>
        /// Get all teams of a specific competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <returns>List of the teams of the specific competition.</returns>
        public TeamRequest GetTeams(int competition)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/teams";

            return ExecuteRequest<TeamRequest>(url);
        }

        /// <summary>
        /// Get all teams of a specific competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="year">Year of the competition.</param>
        /// <returns>List of the teams of the specific competition.</returns>
        public TeamRequest GetTeams(int competition, int year)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/teams?season={year}";

            return ExecuteRequest<TeamRequest>(url);
        }

        /// <summary>
        /// Get all teams of a specific competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="stage">Stage of the competition.</param>
        /// <returns>List of the teams of the specific competition.</returns>
        public TeamRequest GetTeams(int competition, Stage stage)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/teams?stage={stage}";

            return ExecuteRequest<TeamRequest>(url);
        }

        /// <summary>
        /// Get all teams of a specific competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="stage">Stage of the competition.</param>
        /// <param name="year">Year of the competition.</param>
        /// <returns>List of the teams of the specific competition.</returns>
        public TeamRequest GetTeams(int competition, int year, Stage stage)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/teams?season={year}&stage={stage}";

            return ExecuteRequest<TeamRequest>(url);
        }
    }
}
