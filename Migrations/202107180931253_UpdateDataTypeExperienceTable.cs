namespace Profolio_ASPDotNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataTypeExperienceTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Experiences", "CompanyName", c => c.String());
            AlterColumn("dbo.Experiences", "StartDate", c => c.String());
            AlterColumn("dbo.Experiences", "EndDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experiences", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Experiences", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Experiences", "CompanyName", c => c.Int(nullable: false));
        }
    }
}
