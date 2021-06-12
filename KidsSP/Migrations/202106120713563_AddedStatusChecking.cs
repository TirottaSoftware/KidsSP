namespace KidsSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedStatusChecking : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilyUnitStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyUnitId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FamilyUnits", t => t.FamilyUnitId, cascadeDelete: true)
                .Index(t => t.FamilyUnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FamilyUnitStatus", "FamilyUnitId", "dbo.FamilyUnits");
            DropIndex("dbo.FamilyUnitStatus", new[] { "FamilyUnitId" });
            DropTable("dbo.FamilyUnitStatus");
        }
    }
}
