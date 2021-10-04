namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Pass", c => c.String(nullable: false));
            AddColumn("dbo.User", "AddressLine1", c => c.String(maxLength: 50));
            AddColumn("dbo.User", "AddressLine2", c => c.String(maxLength: 50));
            DropColumn("dbo.User", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Password", c => c.String(nullable: false));
            DropColumn("dbo.User", "AddressLine2");
            DropColumn("dbo.User", "AddressLine1");
            DropColumn("dbo.User", "Pass");
        }
    }
}
