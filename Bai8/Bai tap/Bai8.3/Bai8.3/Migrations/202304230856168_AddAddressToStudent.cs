namespace Bai8._3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressToStudent : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.accounts");
            AlterColumn("dbo.accounts", "id", c => c.Int(nullable: false));
            AlterColumn("dbo.accounts", "username", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.accounts", "fullname", c => c.String(nullable: false, maxLength: 50));
            AddPrimaryKey("dbo.accounts", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.accounts");
            AlterColumn("dbo.accounts", "fullname", c => c.String());
            AlterColumn("dbo.accounts", "username", c => c.String());
            AlterColumn("dbo.accounts", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.accounts", "id");
        }
    }
}
