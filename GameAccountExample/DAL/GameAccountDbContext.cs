using GameAccountExample.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace GameAccountExample.DAL
{
    public class GameAccountDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        // Your context has been configured to use a 'GameAccountDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'GameAccountExample.Models.GameAccountDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GameAccountDbContext' 
        // connection string in the application configuration file.
        public GameAccountDbContext()
            : base("name=GameAccountDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }


}