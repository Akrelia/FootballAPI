using System;
using System.Net.Http;
using FootballAPI.Utils;

namespace FootballAPI.Client
{
    /// <summary>
    /// Football API Http client.
    /// </summary>
    public class FootballClient : HttpClient
    {
        /// <summary>
        /// Http client time out in seconds.
        /// </summary>
        public const float TimeOut = 10;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="token">API Token.</param>
        public FootballClient(string token) : this(token, TimeOut)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="token">API Token.</param>
        /// <param name="timeOut">Time out.</param>
        public FootballClient(string token, float timeOut)
        {
            DefaultRequestHeaders.Add("Accept-Language", "fr_FR");
            DefaultRequestHeaders.Add("User-Agent", "FootballService API 1.0");

            Timeout = TimeSpan.FromSeconds(timeOut);

            if (Tools.IsTokenValid(token, out string error))
            {
                DefaultRequestHeaders.Add("X-Auth-Token", token);
            }

            else
            {
                throw new Exception(error);
            }
        }
    }
}
