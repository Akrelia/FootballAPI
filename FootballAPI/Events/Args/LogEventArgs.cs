using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAPI.Events.Args
{
    /// <summary>
    /// Args for the log event handler.
    /// </summary>
    public class LogEventArgs : EventArgs
    {
        string code;
        string message;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Code.</param>
        /// <param name="message">Message.</param>
        public LogEventArgs(string code, string message)
        {
            this.code = code;
            this.message = message;
        }

        /// <summary>
        /// Get the code.
        /// </summary>
        public string Code
        {
            get { return code; }
        }

        /// <summary>
        /// Get the message.
        /// </summary>
        public string Message
        {
            get { return message; }
        }
    }
}
