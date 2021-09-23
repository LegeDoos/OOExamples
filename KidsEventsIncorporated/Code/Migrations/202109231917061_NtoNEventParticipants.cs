namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NtoNRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Event", "Child_ChildId", "dbo.Child");
            DropForeignKey("dbo.Event", "Child_ChildId1", "dbo.Child");
            DropIndex("dbo.Event", new[] { "Child_ChildId" });
            DropIndex("dbo.Event", new[] { "Child_ChildId1" });
            CreateTable(
                "dbo.ChildEvent",
                c => new
                    {
                        Child_ChildId = c.Int(nullable: false),
                        Event_EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Child_ChildId, t.Event_EventID })
                .ForeignKey("dbo.Child", t => t.Child_ChildId, cascadeDelete: true)
                .ForeignKey("dbo.Event", t => t.Event_EventID, cascadeDelete: true)
                .Index(t => t.Child_ChildId)
                .Index(t => t.Event_EventID);
            
            DropColumn("dbo.Event", "Child_ChildId");
            DropColumn("dbo.Event", "Child_ChildId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Event", "Child_ChildId1", c => c.Int());
            AddColumn("dbo.Event", "Child_ChildId", c => c.Int());
            DropForeignKey("dbo.ChildEvent", "Event_EventID", "dbo.Event");
            DropForeignKey("dbo.ChildEvent", "Child_ChildId", "dbo.Child");
            DropIndex("dbo.ChildEvent", new[] { "Event_EventID" });
            DropIndex("dbo.ChildEvent", new[] { "Child_ChildId" });
            DropTable("dbo.ChildEvent");
            CreateIndex("dbo.Event", "Child_ChildId1");
            CreateIndex("dbo.Event", "Child_ChildId");
            AddForeignKey("dbo.Event", "Child_ChildId1", "dbo.Child", "ChildId");
            AddForeignKey("dbo.Event", "Child_ChildId", "dbo.Child", "ChildId");
        }
    }
}
