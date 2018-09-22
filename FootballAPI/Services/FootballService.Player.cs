using FootballAPI.Models;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with player requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Get a player by its id.
        /// </summary>
        /// <returns>Player.</returns>
        public Player GetPlayer(int id)
        {
            string url = $"http://api.football-data.org/v2/players/{id}";

            return ExecuteData<Player>(url);
        }
    }
}
