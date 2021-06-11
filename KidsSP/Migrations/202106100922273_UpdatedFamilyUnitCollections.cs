namespace KidsSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedFamilyUnitCollections : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Children",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        FamilyUnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FamilyUnits", t => t.FamilyUnitId, cascadeDelete: true)
                .Index(t => t.FamilyUnitId);
            
            AddColumn("dbo.Users", "FamilyUnit_Id", c => c.Int());
            CreateIndex("dbo.Users", "FamilyUnit_Id");
            AddForeignKey("dbo.Users", "FamilyUnit_Id", "dbo.FamilyUnits", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "FamilyUnit_Id", "dbo.FamilyUnits");
            DropForeignKey("dbo.Children", "FamilyUnitId", "dbo.FamilyUnits");
            DropIndex("dbo.Users", new[] { "FamilyUnit_Id" });
            DropIndex("dbo.Children", new[] { "FamilyUnitId" });
            DropColumn("dbo.Users", "FamilyUnit_Id");
            DropTable("dbo.Children");
        }
    }
}
