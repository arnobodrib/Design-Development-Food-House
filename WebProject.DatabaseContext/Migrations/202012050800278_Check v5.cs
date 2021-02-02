namespace WebProject.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Checkv5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "name");
        }
    }
}
