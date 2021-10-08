namespace GameAccountExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGameIdentifier : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "GameIdentifier", c => c.String(maxLength: 10));
            CreateIndex("dbo.Games", "GameIdentifier", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Games", new[] { "GameIdentifier" });
            DropColumn("dbo.Games", "GameIdentifier");
        }
    }
}
