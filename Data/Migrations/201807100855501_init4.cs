namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminUsers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CallUsers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        EmployeeID = c.Guid(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        Address = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FinishedOrders",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Details = c.String(),
                        Location = c.String(),
                        Earn = c.Decimal(precision: 18, scale: 2),
                        Longtude = c.Double(),
                        Latitude = c.Double(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        VehicleID = c.Guid(),
                        VehicleNumber = c.Int(),
                        CustomerID = c.Guid(nullable: false),
                        CustomerName = c.String(),
                        EmployeeID = c.Guid(),
                        EmployeeNaame = c.String(),
                        CallUserID = c.Guid(),
                        SenderUserID = c.Guid(),
                        CallUserName = c.String(),
                        SenderUserName = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.SenderUsers", t => t.SenderUserID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID)
                .ForeignKey("dbo.CallUsers", t => t.CallUserID)
                .Index(t => t.VehicleID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.CallUserID)
                .Index(t => t.SenderUserID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Name = c.String(),
                        Location = c.String(),
                        Phone = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SenderUsers",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        EmployeeID = c.Guid(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        VehicleTypeID = c.Guid(),
                        Number = c.Int(),
                        Longtude = c.Double(),
                        Latitude = c.Double(),
                        IsAvailable = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleTypes", t => t.VehicleTypeID)
                .Index(t => t.VehicleTypeID);
            
            CreateTable(
                "dbo.VehicleTypes",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Time = c.Time(nullable: false, precision: 7),
                        Details = c.String(),
                        CustomerPhone = c.String(),
                        Location = c.String(),
                        Status = c.Int(nullable: false),
                        Updated = c.Int(),
                        Earn = c.Decimal(precision: 18, scale: 2),
                        WithTimer = c.Boolean(nullable: false),
                        Timer = c.Int(),
                        BikeTime = c.Time(precision: 7),
                        Longtude = c.Double(),
                        Latitude = c.Double(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                        VehicleID = c.Guid(),
                        CustomerID = c.Guid(nullable: false),
                        CustomerName = c.String(),
                        EmployeeID = c.Guid(),
                        CallUserID = c.Guid(),
                        SenderUserID = c.Guid(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CallUsers", t => t.CallUserID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.SenderUsers", t => t.SenderUserID)
                .ForeignKey("dbo.Vehicles", t => t.VehicleID)
                .Index(t => t.VehicleID)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.CallUserID)
                .Index(t => t.SenderUserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.Orders", "SenderUserID", "dbo.SenderUsers");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CallUserID", "dbo.CallUsers");
            DropForeignKey("dbo.FinishedOrders", "CallUserID", "dbo.CallUsers");
            DropForeignKey("dbo.Vehicles", "VehicleTypeID", "dbo.VehicleTypes");
            DropForeignKey("dbo.FinishedOrders", "VehicleID", "dbo.Vehicles");
            DropForeignKey("dbo.FinishedOrders", "SenderUserID", "dbo.SenderUsers");
            DropForeignKey("dbo.SenderUsers", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.FinishedOrders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.FinishedOrders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.CallUsers", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.Orders", new[] { "SenderUserID" });
            DropIndex("dbo.Orders", new[] { "CallUserID" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Orders", new[] { "VehicleID" });
            DropIndex("dbo.Vehicles", new[] { "VehicleTypeID" });
            DropIndex("dbo.SenderUsers", new[] { "EmployeeID" });
            DropIndex("dbo.FinishedOrders", new[] { "SenderUserID" });
            DropIndex("dbo.FinishedOrders", new[] { "CallUserID" });
            DropIndex("dbo.FinishedOrders", new[] { "EmployeeID" });
            DropIndex("dbo.FinishedOrders", new[] { "CustomerID" });
            DropIndex("dbo.FinishedOrders", new[] { "VehicleID" });
            DropIndex("dbo.CallUsers", new[] { "EmployeeID" });
            DropTable("dbo.Orders");
            DropTable("dbo.VehicleTypes");
            DropTable("dbo.Vehicles");
            DropTable("dbo.SenderUsers");
            DropTable("dbo.Customers");
            DropTable("dbo.FinishedOrders");
            DropTable("dbo.Employees");
            DropTable("dbo.CallUsers");
            DropTable("dbo.AdminUsers");
        }
    }
}
