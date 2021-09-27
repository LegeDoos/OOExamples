using GameAccountExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameAccountExample.ViewModels
{
    public class PlayersPerGameViewModel
    {
        public Game Game { get; set; }

        public ICollection<User> Users { get; set; }
    }
}