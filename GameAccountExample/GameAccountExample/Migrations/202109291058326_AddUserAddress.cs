namespace GameAccountExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "AddressLine1", c => c.String(maxLength: 50));
            AddColumn("dbo.User", "AddressLine2", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "AddressLine2");
            DropColumn("dbo.User", "AddressLine1");
        }
    }
}
