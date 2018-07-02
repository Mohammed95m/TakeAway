namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ninit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FinishedOrders", "VehicleNumber", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FinishedOrders", "VehicleNumber");
        }
    }
}
