namespace Bai8._3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.accounts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        fullname = c.String(),
                        phone = c.String(),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.accounts");
        }
    }
}
