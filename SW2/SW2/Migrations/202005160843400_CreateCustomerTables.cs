namespace SW2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.String(),
                        lname = c.String(),
                        address = c.String(),
                        phone_namber = c.Int(nullable: false),
                        date_birth = c.String(),
                        email = c.String(),
                        credit_card = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
