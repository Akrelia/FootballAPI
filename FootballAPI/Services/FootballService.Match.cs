using System;
using FootballAPI.Models;
using FootballAPI.Models.Enums;
using FootballAPI.Models.Requests;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with match requests.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// String date format used.
        /// </summary>
        private const string DateFormat = "{0:yyyy-MM-dd}";

        /// <summary>
        /// Get all matches for a competition.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <returns>List of the matches for the specific competition.</returns>
        public MatchRequest GetMatches(int competition)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/matches";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches for a competition with a specific status.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="status">Status filter.</param>
        /// <returns>List of the matches for the specific competition.</returns>
        public MatchRequest GetMatches(int competition, Status status)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/matches?status={status}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches for a competition of a specific matchday.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="matchday">Matchday filter.</param>
        /// <returns>List of the matches for the specific competition.</returns>
        public MatchRequest GetMatches(int competition, short matchday)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/matches?matchday={matchday}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches for a competition of a specific matchday and status.
        /// </summary>
        /// <param name="competition">Id of the competition.</param>
        /// <param name="matchday">Matchday filter.</param>
        /// <param name="status">Status filter.</param>
        /// <returns>List of the matches for the specific competition.</returns>
        public MatchRequest GetMatches(int competition, short matchday, Status status)
        {
            string url = $"http://api.football-data.org/v2/competitions/{competition}/matches?matchday={matchday}&status={status}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches for a specific competition. 
        /// </summary>
        /// <param name="competition">Competition.</param>
        /// <returns>List of the matches for the specific competition.</returns>
        public MatchRequest GetMatches(Competition competition)
        {
            return GetMatches(competition.Id);
        }

        /// <summary>
        /// Get all matches for a specific competition and matchday.
        /// </summary>
        /// <param name="competition">Competition.</param>
        /// <param name="matchday">Matchday.</param>
        /// <returns>List of the matches for the specific competition and matchday.</returns>
        public MatchRequest GetMatches(Competition competition, short matchday)
        {
            return GetMatches(competition.Id, matchday);
        }

        /// <summary>
        /// Get all matches for a specific competition with a specific status.
        /// </summary>
        /// <param name="competition">Competition.</param>
        /// <param name="status">Status.</param>
        /// <returns>List of the matches for the specific competition and status.</returns>
        public MatchRequest GetMatches(Competition competition, Status status)
        {
            return GetMatches(competition.Id, status);
        }

        /// <summary>
        /// Get all matches with all filters.
        /// </summary>
        /// <param name="competition">Competition.</param>
        /// <param name="matchday">Matchday.</param>
        /// <param name="status">Status.</param>
        /// <returns>List of the matchs with all filters.</returns>
        public MatchRequest GetMatches(Competition competition, short matchday, Status status)
        {
            return GetMatches(competition.Id, matchday, status);
        }

        /// <summary>
        /// Get all matches of a team.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <returns>List of matches for the specific team.</returns>
        public MatchRequest GetMatches(Team team)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches of a team.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <param name="status">Status of the matches.</param>
        /// <returns>List of matches for the specific team.</returns>
        public MatchRequest GetMatches(Team team, Status status)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches?status={status}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches of a team.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <param name="venue">Venue.</param>
        /// <returns>List of matches for the specific team.</returns>
        public MatchRequest GetMatches(Team team, Venue venue)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches?venue={venue}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches of a team with all filters.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <param name="status">Status.</param>
        /// <param name="venue">Venue.</param>
        /// <returns>List of matches for the specific team with all filters.</returns>
        public MatchRequest GetMatches(Team team, Status status, Venue venue)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches?status{status}&venue={venue}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches of a team between a range of date time.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches for the specific team.</returns>
        public MatchRequest GetMatches(Team team, DateTime dateFrom, DateTime dateTo)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches?dateFrom={dateFrom}&dateTo={dateTo}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get all matches of a team, using all filters.
        /// </summary>
        /// <param name="team">Team id.</param>
        /// <param name="status">Status of the matches.</param>
        /// <returns>List of matches for the specific team.</returns>
        public MatchRequest GetMatches(Team team, Venue venue, Status status, DateTime dateFrom, DateTime dateTo)
        {
            string url = $"http://api.football-data.org/v2/teams/{team.Id}/matches?venue={venue}&status={status}&dateFrom={dateFrom}&dateTo={dateTo}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get matches with all filters.
        /// </summary>
        /// <param name="competitions">List of competitions.</param>
        /// <param name="status">Match status.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches.</returns>
        public MatchRequest GetMatches(int competition, Status status, DateTime dateFrom, DateTime dateTo)
        {
            string from = String.Format(DateFormat, dateFrom);
            string to = String.Format(DateFormat, dateTo);
            string url = $"http://api.football-data.org/v2/matches?competitions={competition},&status={status}&dateFrom={from}&dateTo={to}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get matches with all filters.
        /// </summary>
        /// <param name="competitions">List of competitions.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches.</returns>
        public MatchRequest GetMatches(string[] competitions, DateTime dateFrom, DateTime dateTo)
        {
            string filter = BuildCompetitionFilter(competitions);
            string from = String.Format(DateFormat, dateFrom);
            string to = String.Format(DateFormat, dateTo);

            string url = $"http://api.football-data.org/v2/matches?competitions={filter}&dateFrom={from}&dateTo={to}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get matches with all filters.
        /// </summary>
        /// <param name="competitions">List of competitions.</param>
        /// <param name="status">Match status.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches.</returns>
        public MatchRequest GetMatches(string[] competitions, Status status, DateTime dateFrom, DateTime dateTo)
        {
            string filter = BuildCompetitionFilter(competitions);
            string from = String.Format(DateFormat, dateFrom);
            string to = String.Format(DateFormat, dateTo);

            string url = $"http://api.football-data.org/v2/matches?competitions={filter}&status={status}&dateFrom={from}&dateTo={to}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get matches with all filters.
        /// </summary>
        /// <param name="competitions">List of competitions.</param>
        /// <param name="status">Match status.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches.</returns>
        public MatchRequest GetMatches(Competition[] competitions, Status status, DateTime dateFrom, DateTime dateTo)
        {
            string filter = BuildCompetitionFilter(competitions);
            string from = String.Format(DateFormat, dateFrom);
            string to = String.Format(DateFormat, dateTo);

            string url = $"http://api.football-data.org/v2/matches?competitions={filter}&status={status}&dateFrom={from}&dateTo={to}";

            return ExecuteRequest<MatchRequest>(url);
        }

        /// <summary>
        /// Get matches with all filters.
        /// </summary>
        /// <param name="competitions">List of competitions.</param>
        /// <param name="dateFrom">Date from.</param>
        /// <param name="dateTo">Date to.</param>
        /// <returns>List of matches.</returns>
        public MatchRequest GetMatches(Competition[] competitions, DateTime dateFrom, DateTime dateTo)
        {
            string filter = BuildCompetitionFilter(competitions);
            string from = String.Format(DateFormat, dateFrom);
            string to = String.Format(DateFormat, dateTo);

            string url = $"http://api.football-data.org/v2/matches?competitions={filter}&dateFrom={from}&dateTo={to}";

            return ExecuteRequest<MatchRequest>(url);
        }
    }
}
