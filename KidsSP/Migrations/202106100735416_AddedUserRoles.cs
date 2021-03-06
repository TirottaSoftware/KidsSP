namespace KidsSP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedUserRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Discriminator");
        }
    }
}
