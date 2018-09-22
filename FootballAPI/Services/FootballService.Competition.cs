using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballAPI.Models;
using FootballAPI.Models.Enums;
using FootballAPI.Models.Requests;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with competition requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Get a specific competition.
        /// </summary>
        /// <param name="id">Id of the competition.</param>
        /// <returns>Competition.</returns>
        public Competition GetCompetition(int id)
        {
            string url = $"http://api.football-data.org/v2/competitions/{id}";

            return ExecuteData<Competition>(url);
        }

        /// <summary>
        /// Get a specific competition.
        /// </summary>
        /// <param name="code">Code of the competition.</param>
        /// <returns>Competition.</returns>
        public Competition GetCompetition(string code)
        {
            string url = $"http://api.football-data.org/v2/competitions/{code}";

            return ExecuteData<Competition>(url);
        }

        /// <summary>
        /// Get all competitions.
        /// </summary>
        /// <returns>Competitions.</returns>
        public CompetitionRequest GetCompetitions()
        {
            string url = $"http://api.football-data.org/v2/competitions/";

            return ExecuteRequest<CompetitionRequest>(url);
        }

        /// <summary>
        /// Get all competitions for a specific plan.
        /// </summary>
        /// <param name="plan">Specific plan.</param>
        /// <returns>Competitions.</returns>
        public CompetitionRequest GetCompetitions(Plan plan)
        {
            string url = $"http://api.football-data.org/v2/competitions?plan={plan}";

            return ExecuteRequest<CompetitionRequest>(url);
        }

        /// <summary>
        /// Get all competitions for a specific area.
        /// </summary>
        /// <param name="area">Specific area.</param>
        /// <returns>Competitions.</returns>
        public CompetitionRequest GetCompetitions(Area area)
        {
            string url = $"http://api.football-data.org/v2/competitions?areas={area.Id}";

            return ExecuteRequest<CompetitionRequest>(url);
        }

        /// <summary>
        /// Get all competitions using all filters.
        /// </summary>
        /// <param name="plan">Specific plan.</param>
        /// <param name="area">Specific area.</param>
        /// <returns>Competitions.</returns>
        public CompetitionRequest GetCompetitions(Plan plan, Area area)
        {
            string url = $"http://api.football-data.org/v2/competitions?areas={area.Id}&plan={plan}";

            return ExecuteRequest<CompetitionRequest>(url);
        }
    }
}
