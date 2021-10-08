namespace GameAccountExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MinPlayers = c.Int(nullable: false),
                        MaxPlayers = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 15),
                        Pass = c.String(),
                        FriendlyName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.UserName, unique: true);
            
            CreateTable(
                "dbo.UserGames",
                c => new
                    {
                        User_UserID = c.Int(nullable: false),
                        Game_GameID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_UserID, t.Game_GameID })
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.Game_GameID, cascadeDelete: true)
                .Index(t => t.User_UserID)
                .Index(t => t.Game_GameID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserGames", "Game_GameID", "dbo.Games");
            DropForeignKey("dbo.UserGames", "User_UserID", "dbo.Users");
            DropIndex("dbo.UserGames", new[] { "Game_GameID" });
            DropIndex("dbo.UserGames", new[] { "User_UserID" });
            DropIndex("dbo.Users", new[] { "UserName" });
            DropTable("dbo.UserGames");
            DropTable("dbo.Users");
            DropTable("dbo.Games");
        }
    }
}
