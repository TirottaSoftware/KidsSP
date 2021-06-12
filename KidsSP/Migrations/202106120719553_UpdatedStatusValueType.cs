namespace KidsSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedStatusValueType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.FamilyUnitStatus", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.FamilyUnitStatus", "Status", c => c.Int(nullable: false));
        }
    }
}
