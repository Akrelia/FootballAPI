using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballAPI.Events.Args;

namespace FootballAPI.Services
{
    /// <summary>
    /// Everything related to the events.
    /// </summary>
    public partial class FootballService
    {
        /// <summary>
        /// Log event handler.
        /// </summary>
        public event OnLogEventHandler Log;

        /// <summary>
        /// On log.
        /// </summary>
        /// <param name="e">Log event args.</param>
        protected virtual void OnLog(LogEventArgs e)
        {
            Log?.Invoke(this, e);
        }

        /// <summary>
        /// Create log.
        /// </summary>
        /// <param name="code">Code of the log.</param>
        /// <param name="message">Message of the log.</param>
        private void CreateLog(string code, string message)
        {
            if (!String.IsNullOrEmpty(message))
            {
                LogEventArgs args = new LogEventArgs(code, message);

                OnLog(args);
            }
        }

        /// <summary>
        /// Delegate for the log event handler.
        /// </summary>
        /// <param name="sender">Object who sent the event.</param>
        /// <param name="e">Args.</param>
        public delegate void OnLogEventHandler(Object sender, LogEventArgs e);
    }
}
