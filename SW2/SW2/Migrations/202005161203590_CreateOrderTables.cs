namespace SW2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrderTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        medicine_id = c.Int(nullable: false),
                        customer_id = c.Int(nullable: false),
                        accept = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Customers", t => t.customer_id, cascadeDelete: true)
                .ForeignKey("dbo.Medicines", t => t.medicine_id, cascadeDelete: true)
                .Index(t => t.medicine_id)
                .Index(t => t.customer_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "medicine_id", "dbo.Medicines");
            DropForeignKey("dbo.Orders", "customer_id", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "customer_id" });
            DropIndex("dbo.Orders", new[] { "medicine_id" });
            DropTable("dbo.Orders");
        }
    }
}
