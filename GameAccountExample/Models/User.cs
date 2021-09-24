using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameAccountExample.Models
{
    /// <summary>
    /// Represents a user in the application
    /// </summary>
    public class User
    {
        /// <summary>
        /// Identifier of the user (PK)
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Unique username of the user
        /// </summary>
        [Index(IsUnique = true), StringLength(15), DisplayName("User name")]
        public string UserName { get; set; }
        /// <summary>
        /// The password of the user
        /// </summary>
        [DataType(DataType.Password), DisplayName("Password")] 
        public string Pass { get; set; }
        /// <summary>
        /// The friendlyname (display) of the user
        /// </summary>
        [DisplayName("Display name")]
        public string FriendlyName { get; set; }
        /// <summary>
        /// The email address to contact the user
        /// </summary>
        [DataType(DataType.EmailAddress), DisplayName("Email address")]
        public string Email { get; set; }
        /// <summary>
        /// The games that the user plays
        /// </summary>
        public virtual ICollection<Game> Games { get; set; }
    }
}