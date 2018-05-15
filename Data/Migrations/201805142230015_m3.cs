namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "BikeTime", c => c.Time(precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "BikeTime");
        }
    }
}
