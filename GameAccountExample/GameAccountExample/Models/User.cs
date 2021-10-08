using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        /// Address line 1 of the user: street
        /// </summary>
        [StringLength(50)]
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Address line 2: town, postalcode
        /// </summary>
        [StringLength(50)]
        public string AddressLine2 { get; set; }
        /// <summary>
        /// The games that the user plays
        /// </summary>
        public virtual ICollection<Game> Games { get; set; }

        public string GravatarURL{ 
            get
            {
                    // Create MD5 Hash of email address
                    var md5 = System.Security.Cryptography.MD5.Create();
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(this.Email.Trim().ToLower());
                    byte[] hash = md5.ComputeHash(inputBytes);
                    // Create lower-case hex string
                    var sb = new System.Text.StringBuilder();
                    for (int i = 0; i < hash.Length; i++)
                    {
                        sb.Append(hash[i].ToString("x2"));
                    }
                    // Build URL
                    return string.Concat("http://www.gravatar.com/avatar/", sb);
            }
        }
    }
}