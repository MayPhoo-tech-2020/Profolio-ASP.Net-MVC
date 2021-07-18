namespace Profolio_ASPDotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpatedExperienceTabe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experiences", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experiences", "Position");
        }
    }
}
