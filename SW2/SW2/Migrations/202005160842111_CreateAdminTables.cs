namespace SW2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAdminTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fname = c.String(),
                        lname = c.String(),
                        phone_namber = c.Int(nullable: false),
                        date_birth = c.String(),
                        email = c.String(),
                        card_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
