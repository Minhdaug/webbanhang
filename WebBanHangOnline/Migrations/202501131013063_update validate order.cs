namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatevalidateorder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false));
        }
    }
}
