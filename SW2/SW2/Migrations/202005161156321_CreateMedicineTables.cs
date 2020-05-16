namespace SW2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMedicineTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        Date = c.DateTime(nullable: false),
                        price = c.Int(nullable: false),
                        amount = c.Int(nullable: false),
                        vendor_by = c.String(),
                        effictive_sub = c.String(),
                        special_instruction = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Medicines");
        }
    }
}
