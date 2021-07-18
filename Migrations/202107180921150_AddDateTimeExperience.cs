namespace Profolio_ASPDotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTimeExperience : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experiences", "StartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Experiences", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experiences", "EndDate");
            DropColumn("dbo.Experiences", "StartDate");
        }
    }
}
