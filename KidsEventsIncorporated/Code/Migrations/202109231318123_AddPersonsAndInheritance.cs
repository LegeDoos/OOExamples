namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonsAndInheritance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false),
                        Firstname = c.String(maxLength: 50),
                        Lastname = c.String(maxLength: 50),
                        Email = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Child",
                c => new
                    {
                        ChildId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        BirthDate = c.DateTime(nullable: false),
                        Parent_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ChildId)
                .ForeignKey("dbo.User", t => t.Parent_ID)
                .Index(t => t.Parent_ID);
            
            AddColumn("dbo.Event", "OrganisingWorker_ID", c => c.Int());
            AddColumn("dbo.Event", "Child_ChildId", c => c.Int());
            AddColumn("dbo.Event", "Child_ChildId1", c => c.Int());
            AddColumn("dbo.Event", "Worker_ID", c => c.Int());
            CreateIndex("dbo.Event", "OrganisingWorker_ID");
            CreateIndex("dbo.Event", "Child_ChildId");
            CreateIndex("dbo.Event", "Child_ChildId1");
            CreateIndex("dbo.Event", "Worker_ID");
            AddForeignKey("dbo.Event", "OrganisingWorker_ID", "dbo.User", "ID");
            AddForeignKey("dbo.Event", "Child_ChildId", "dbo.Child", "ChildId");
            AddForeignKey("dbo.Event", "Child_ChildId1", "dbo.Child", "ChildId");
            AddForeignKey("dbo.Event", "Worker_ID", "dbo.User", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Event", "Worker_ID", "dbo.User");
            DropForeignKey("dbo.Child", "Parent_ID", "dbo.User");
            DropForeignKey("dbo.Event", "Child_ChildId1", "dbo.Child");
            DropForeignKey("dbo.Event", "Child_ChildId", "dbo.Child");
            DropForeignKey("dbo.Event", "OrganisingWorker_ID", "dbo.User");
            DropIndex("dbo.Child", new[] { "Parent_ID" });
            DropIndex("dbo.Event", new[] { "Worker_ID" });
            DropIndex("dbo.Event", new[] { "Child_ChildId1" });
            DropIndex("dbo.Event", new[] { "Child_ChildId" });
            DropIndex("dbo.Event", new[] { "OrganisingWorker_ID" });
            DropColumn("dbo.Event", "Worker_ID");
            DropColumn("dbo.Event", "Child_ChildId1");
            DropColumn("dbo.Event", "Child_ChildId");
            DropColumn("dbo.Event", "OrganisingWorker_ID");
            DropTable("dbo.Child");
            DropTable("dbo.User");
        }
    }
}
