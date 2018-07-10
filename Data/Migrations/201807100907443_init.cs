namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsBike", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsBike");
        }
    }
}
