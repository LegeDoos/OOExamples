using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidsEventsIncorporated.Models
{
    public class User
    {
        /// <summary>
        /// The unique id of a user, PK
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Username of the user
        /// </summary>
        [StringLength(15)]
        [Required]
        public string Username { get; set; }
        /// <summary>
        /// Password of the user
        /// </summary>
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        /// <summary>
        /// Real firstname of the user
        /// </summary>
        [StringLength(50)]
        public string Firstname { get; set; }
        /// <summary>
        /// Real lastname of the user
        /// </summary>
        [StringLength(50)]
        public string Lastname { get; set; }
        /// <summary>
        /// Email address of the user
        /// </summary>
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        /// <summary>
        /// Status showing if the user is enabled (true) or not
        /// </summary>
        public bool Status { get; set; } = true;

    }
}