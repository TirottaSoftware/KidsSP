namespace KidsSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedFamilyUnits : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FamilyUnits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyUnitName = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            AddColumn("dbo.Users", "DateOfBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "DateOfBirth");
            DropColumn("dbo.Users", "PhoneNumber");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropTable("dbo.FamilyUnits");
        }
    }
}
