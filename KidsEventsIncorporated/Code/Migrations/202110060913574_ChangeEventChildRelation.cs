namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ChildEvent", newName: "EventChild");
            DropPrimaryKey("dbo.EventChild");
            AddPrimaryKey("dbo.EventChild", new[] { "Event_EventID", "Child_ChildId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.EventChild");
            AddPrimaryKey("dbo.EventChild", new[] { "Child_ChildId", "Event_EventID" });
            RenameTable(name: "dbo.EventChild", newName: "ChildEvent");
        }
    }
}
