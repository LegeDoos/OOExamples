namespace KidsEventsIncorporated.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventType = c.Int(nullable: false),
                        Description = c.String(maxLength: 500),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        MaxParticipants = c.Int(),
                        MinumumAgeParticipants = c.Int(),
                        MaximumAgeParticipants = c.Int(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Event");
        }
    }
}
