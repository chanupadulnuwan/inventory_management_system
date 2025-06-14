using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventryUI
{
    public static class Session
    {
        /// <summary>
        /// Stores the ID of the currently logged-in user.
        /// This should be set upon successful login.
        /// </summary>
        public static int CurrentUserId { get; set; }

        /// <summary>
        /// Optional: Stores the username of the currently logged-in user.
        /// </summary>
        public static string CurrentUsername { get; set; }

        /// <summary>
        /// Optional: Stores the role of the currently logged-in user.
        /// </summary>
        public static string CurrentUserRole { get; set; }

        /// <summary>
        /// Clears the session data, typically on logout.
        /// </summary>
        public static void Clear()
        {
            CurrentUserId = 0; // Or -1, or some indicator of no user
            CurrentUsername = null;
            CurrentUserRole = null;
        }
    }
}
