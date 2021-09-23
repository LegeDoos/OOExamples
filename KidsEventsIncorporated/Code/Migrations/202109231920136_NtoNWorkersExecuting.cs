namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NtoNWorkersExecuting : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Event", "Worker_ID", "dbo.User");
            DropIndex("dbo.Event", new[] { "Worker_ID" });
            CreateTable(
                "dbo.WorkerEvent",
                c => new
                    {
                        Worker_ID = c.Int(nullable: false),
                        Event_EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Worker_ID, t.Event_EventID })
                .ForeignKey("dbo.User", t => t.Worker_ID, cascadeDelete: true)
                .ForeignKey("dbo.Event", t => t.Event_EventID, cascadeDelete: true)
                .Index(t => t.Worker_ID)
                .Index(t => t.Event_EventID);
            
            DropColumn("dbo.Event", "Worker_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Event", "Worker_ID", c => c.Int());
            DropForeignKey("dbo.WorkerEvent", "Event_EventID", "dbo.Event");
            DropForeignKey("dbo.WorkerEvent", "Worker_ID", "dbo.User");
            DropIndex("dbo.WorkerEvent", new[] { "Event_EventID" });
            DropIndex("dbo.WorkerEvent", new[] { "Worker_ID" });
            DropTable("dbo.WorkerEvent");
            CreateIndex("dbo.Event", "Worker_ID");
            AddForeignKey("dbo.Event", "Worker_ID", "dbo.User", "ID");
        }
    }
}
