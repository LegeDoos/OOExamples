using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameAccountExample.Models
{
    /// <summary>
    /// Represents the game
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Id of the game (PK)
        /// </summary>
        public int GameID { get; set; }
        /// <summary>
        /// Unique identifier of a game
        /// </summary>
        [Index(IsUnique = true), StringLength(10), ]
        public string GameIdentifier { get; set; }
        /// <summary>
        /// The title identifying the game
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The minimum number of players
        /// </summary>
        public int MinPlayers { get; set; }
        /// <summary>
        /// The maximum number of players
        /// </summary>
        public int MaxPlayers { get; set; }
        /// <summary>
        /// List of users that play the game
        /// </summary>
        public ICollection<User> Users { get; set; }

        /// <summary>
        /// Add the users from the list to the game if conditions are met
        /// </summary>
        /// <param name="_users">The list of users to add</param>
        /// <returns>true on success</returns>
        public bool AddUsersToGame(List<User> _users)
        {
            // add checks if I'm allowed to add the users of if it is allowed to add the users given the user count on the game
            // return false;
            if (_users == null)
                throw new NullReferenceException("Users moeten worden opgegeven!");

            // add users to the game that do not already exist
            foreach (var user in _users)
            {
                if (!this.Users.Contains(user))
                {
                    this.Users.Add(user);
                    if (this.Users.Count > this.MaxPlayers)
                        return false;
                }
            }
            return true;
        }

    }
}