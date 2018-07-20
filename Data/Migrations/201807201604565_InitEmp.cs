namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitEmp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "VehicleID", c => c.Guid());
            CreateIndex("dbo.Employees", "VehicleID");
            AddForeignKey("dbo.Employees", "VehicleID", "dbo.Vehicles", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "VehicleID", "dbo.Vehicles");
            DropIndex("dbo.Employees", new[] { "VehicleID" });
            DropColumn("dbo.Employees", "VehicleID");
        }
    }
}
