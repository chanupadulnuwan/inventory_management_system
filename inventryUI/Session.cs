using System;

namespace inventryUI
{
    public static class Session
    {
        // User's ID (e.g., set after login)
        public static int CurrentUserId { get; set; }

        // Optional: Username or display name
        public static string CurrentUsername { get; set; }

        // Role of the current user (e.g., "Admin" or "User")
        public static string CurrentUserRole { get; set; } = "Admin";
    }
}
