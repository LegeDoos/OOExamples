namespace GameAccountExample.Migrations
{
    using GameAccountExample.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GameAccountExample.DAL.GameAccountDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameAccountExample.DAL.GameAccountDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            
            Game GameOne = new Game()
            {
                Title = "Gotcha Zuyd!",
                GameIdentifier = "ZUYD",
                MinPlayers = 10,
                MaxPlayers = 500
            };
            
            Game GameTwo = new Game()
            {
                Title = "Gotcha Zuyd Teachers",
                GameIdentifier = "TEACHERS",
                MinPlayers = 5,
                MaxPlayers = 20
            };

            context.Games.AddOrUpdate(g => g.GameIdentifier, GameOne, GameTwo);

            List<Game> games = new List<Game>();
            games.Add(GameOne);

            context.Users.AddOrUpdate(u => u.UserName, 
                new User() { UserName = "user1", Pass = "secret", FriendlyName = "User 1", Email = "user1@users.com", Games = games },
                new User() { UserName = "user2", Pass = "secret", FriendlyName = "User 2", Email = "user2@users.com", Games = games },
                new User() { UserName = "user3", Pass = "secret", FriendlyName = "User 3", Email = "user3@users.com" },
                new User() { UserName = "user4", Pass = "secret", FriendlyName = "User 4", Email = "user4@users.com" },
                new User() { UserName = "pietsnot", Pass = "secret", FriendlyName = "Piet Snot", Email = "piet@snot.nl.com" });

            base.Seed(context);
        }
    }
}
