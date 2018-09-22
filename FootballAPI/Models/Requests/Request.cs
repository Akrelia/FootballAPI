namespace FootballAPI.Models.Requests
{
    /// <summary>
    /// Request class.
    /// </summary>
    public abstract class Request
    {
        /// <summary>
        /// Message for the request.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Get if the request is valid.
        /// </summary>
        public bool IsValid
        {
            get { return string.IsNullOrEmpty(Message); }
        }
    }
}
