using System;
using System.Linq;
using System.Net.Http;
using FootballAPI.Client;
using FootballAPI.Events.Args;
using FootballAPI.Models.Common;
using FootballAPI.Models.Requests;
using Newtonsoft.Json;

namespace FootballAPI.Services
{
    /// <summary>
    /// Service for getting data with requests.
    /// </summary>
    public partial class FootballService
    {
        int counterReset;
        int requestsAvailable;
        string auth;
        string version;
        FootballClient client;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="token">Auth token.</param>
        public FootballService(string token)
        {
            client = new FootballClient(token);
        }

        /// <summary>
        /// Execute a request to get a result.
        /// </summary>
        /// <typeparam name="TRequest">Type of the request.</typeparam>
        /// <param name="url">Url to query.</param>
        /// <returns>Request.</returns>
        public TRequest ExecuteRequest<TRequest>(string url) where TRequest : Request
        {
            var response = client.GetAsync(new Uri(url)).Result;

            string responseString = response.Content.ReadAsStringAsync().Result;

            var error = JsonConvert.DeserializeObject<ErrorResult>(responseString);
            var request = JsonConvert.DeserializeObject<TRequest>(responseString);

            ReadHeaders(response);

            request.Message = error.Message;

            CreateLog(response.StatusCode.ToString(), error.Message);

            return request;
        }


        /// <summary>
        /// Execute a request to get a data only object.
        /// </summary>
        /// <typeparam name="TData">Type of the data.</typeparam>
        /// <param name="url">Url to query.</param>
        /// <returns>Data.</returns>
        public TData ExecuteData<TData>(string url)
        {
            var response = client.GetAsync(new Uri(url)).Result;

            string responseString = response.Content.ReadAsStringAsync().Result;

            var error = JsonConvert.DeserializeObject<ErrorResult>(responseString);
            var data = JsonConvert.DeserializeObject<TData>(responseString);

            ReadHeaders(response);

            CreateLog(response.StatusCode.ToString(), error.Message);

            return data;
        }

        /// <summary>
        /// Read the response's headers for useful informations.
        /// </summary>
        /// <param name="response">Last Http response message.</param>
        private void ReadHeaders(HttpResponseMessage response)
        {
            try
            {
                version = response.Headers.GetValues("X-Api-Version").FirstOrDefault();
                auth = response.Headers.GetValues("X-Authenticated-Client").FirstOrDefault();
                counterReset = Convert.ToInt32(response.Headers.GetValues("X-RequestCounter-Reset").FirstOrDefault());
                requestsAvailable = Convert.ToInt32(response.Headers.GetValues("X-Requests-Available-Minute").FirstOrDefault());
            }

            catch
            {
                CreateLog("Headers", "Failed to read headers");
            }
        }

        /// <summary>
        /// Get the number of requests available since the last request.
        /// </summary>
        public int RequestsAvailable
        {
            get { return requestsAvailable; }
        }

        /// <summary>
        /// Get the counter reset (in seconds) since the last request.
        /// </summary>
        public int CounterReset
        {
            get { return counterReset; }
        }

        /// <summary>
        /// Get the current version of the API since the last request.
        /// </summary>
        public string Version
        {
            get { return version; }
        }

        /// <summary>
        /// Get the current auth using the api since the last request.
        /// </summary>
        public string Auth
        {
            get { return auth; }
        }

        /// <summary>
        /// Get the football client.
        /// </summary>
        public FootballClient Client
        {
            get { return client; }
        }
    }
}
