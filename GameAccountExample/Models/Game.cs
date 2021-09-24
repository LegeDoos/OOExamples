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
    }
}