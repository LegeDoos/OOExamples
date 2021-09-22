using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    public class User
    {
        public int UserID { get; set; }
        /// <summary>
        /// Username of the user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password of the user
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Real firstname of the user
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// Real lastname of the user
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Email address of the user
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Status showing if the user is enabled (true) or not
        /// </summary>
        public bool Status{ get; set; }

    }
}