using System;
using FootballAPI.Events.Args;
using FootballAPI.Models;
using FootballAPI.Models.Enums;
using FootballAPI.Services;

namespace FootballAPIExample
{
    /// <summary>
    /// Main class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            // Create the service first, using your token
            FootballService service = new FootballService("7a0b8ee50bef48b9bef8d7f791d73f45");

            // Subscribe to the Log event - Note that you need to subscribe only if you more informations about the requests
            service.Log += ServiceLog;

            // Display examples
            Competitions(service);
            Matches(service);
            Standings(service);

            // Display the response headers after several requests
            DisplayHeaders(service);

            // Don't let the program close
            Console.ReadKey();
        }

        /// <summary>
        /// Get the competitions.
        /// </summary>
        /// <param name="service">Football service.</param>
        static public void Competitions(FootballService service)
        {
            // Get every competitions available with the tier one (free plan)
            var competitionsRequest = service.GetCompetitions(Plan.TIER_ONE);

            // Check if there is a message, which means something went wrong
            if (competitionsRequest.IsValid)
            {
                // Display ever competitions
                foreach (var competition in competitionsRequest.Competitions)
                {
                    Console.WriteLine($"{competition.Code} | {competition.Name} | ({competition.Area.Name})");
                }
            }

            else
            {
                Console.WriteLine($"Failed to send competition request : {competitionsRequest.Message}");
            }

            // Separatation
            DisplayLine();
        }

        /// <summary>
        /// Get the finished matches of a competition.
        /// </summary>
        /// <param name="service">Football service.</param>
        static public void Matches(FootballService service)
        {
            // Get the Ligue 1 by its code
            var ligue1 = service.GetCompetition("FL1");

            // Get every finished matches of the Ligue 1
            var matchRequest = service.GetMatches(ligue1, Status.FINISHED);

            // Check if there is a message, which means something went wrong
            if (matchRequest.IsValid)
            {
                // Display ever matches
                foreach (var match in matchRequest.Matches)
                {
                    Console.WriteLine($"{match.HomeTeam} vs {match.AwayTeam} ({match.Score.FullTime}) | {match.UTCDate}");
                }
            }

            else
            {
                Console.WriteLine($"Failed to send match request : {matchRequest.Message}");
            }

            // Separatation
            DisplayLine();
        }

        /// <summary>
        /// Get the standings of a competition.
        /// </summary>
        /// <param name="service">Football service.</param>
        static public void Standings(FootballService service)
        {
            // Get the Premiere League by uts code
            var premiereLeague = service.GetCompetition("PL");

            // Get the standing for the Premiere League
            var standingRequest = service.GetStandings(premiereLeague);

            // Check if there is a message, which means something went wrong
            if (standingRequest.IsValid)
            {
                // Display the table of the Premiere League
                foreach (var table in standingRequest.Standings[0].Table) // First standing is the classic standing, there is 3 standings : Full, Home and Away.
                {
                    Console.WriteLine($"{table.Position}. {table.Team} | Points: {table.Points} ({table.GoalDifference})");
                }
            }

            else
            {
                Console.WriteLine($"Failed to send standing request : {standingRequest.Message}");
            }

            // Separatation
            DisplayLine();
        }

        /// <summary>
        /// When the service log something.
        /// </summary>
        private static void ServiceLog(object sender, LogEventArgs e)
        {
            Console.WriteLine($"({e.Code}) {e.Message}");
        }

        /// <summary>
        /// Display response headers.
        /// </summary>
        /// <param name="service">Football service.</param>
        static public void DisplayHeaders(FootballService service)
        {
            Console.WriteLine($"Requests available : {service.RequestsAvailable}");
            Console.WriteLine($"Seconds until request counter reset :  {service.CounterReset}");
            Console.WriteLine($"Account authenticated : {service.Auth}");
            Console.WriteLine($"API version : {service.Version}");
        }

        /// <summary>
        /// Display a line in the console.
        /// </summary>
        static public void DisplayLine()
        {
            Console.Write(Environment.NewLine);
            Console.WriteLine("----------------------------------");
            Console.Write(Environment.NewLine);
        }
    }
}
