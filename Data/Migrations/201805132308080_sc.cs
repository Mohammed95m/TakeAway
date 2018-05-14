namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "Updated", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "Updated");
        }
    }
}
