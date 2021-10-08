namespace GameAccountExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PluralizingTableNameConvention : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Games", newName: "Game");
            RenameTable(name: "dbo.Users", newName: "User");
            RenameTable(name: "dbo.UserGames", newName: "UserGame");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.UserGame", newName: "UserGames");
            RenameTable(name: "dbo.User", newName: "Users");
            RenameTable(name: "dbo.Game", newName: "Games");
        }
    }
}
