using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballAPI.Utils
{
    /// <summary>
    /// Tools for the Football API.
    /// </summary>
    static internal class Tools
    {
        /// <summary>
        /// Check if the token is a valid one.
        /// </summary>
        /// <param name="token">Token to check.</param>
        /// <param name="message">Error message.</param>
        /// <returns>True if </returns>
        static public bool IsTokenValid(string token, out string message)
        {
            if (String.IsNullOrEmpty(token))
            {
                message = "Token can't be empty.";

                return false;
            }

            if (token.Length != 32)
            {
                message = "Token must be 32 character long.";

                return false;
            }

            if (!token.All(Char.IsLetterOrDigit))
            {
                message = "Token must contains only numbers and letters.";

                return false;
            }

            message = "Valid token.";

            return true;
        }
    }
}
