namespace Mini_Avito_ASP.NET_MVC_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addJobTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Jobs", "jobImage", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jobs", "jobImage", c => c.String(nullable: false));
        }
    }
}
