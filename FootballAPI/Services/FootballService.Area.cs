using FootballAPI.Models.Requests;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with area requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Get a specific area with an id.
        /// </summary>
        /// <param name="id">Id of the area.</param>
        /// <returns>Specific area.</returns>
        public AreaRequest GetArea(int id)
        {
            string url = $"http://api.football-data.org/v2/areas/{id}/";

            return ExecuteRequest<AreaRequest>(url);
        }

        /// <summary>
        /// Get all areas available.
        /// </summary>
        /// <returns>All areas.</returns>
        public AreaRequest GetAreas()
        {
            string url = $"http://api.football-data.org/v2/areas/";

            return ExecuteRequest<AreaRequest>(url);
        }
    }
}
