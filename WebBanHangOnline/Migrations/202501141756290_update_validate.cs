namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_validate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false));
        }
    }
}
