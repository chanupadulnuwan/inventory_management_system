using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventryUI
{
    public static class Session
    {
        public static string CurrentUserRole { get; set; } = "Admin";
        // Set to "User" for testing user view
    }
}
