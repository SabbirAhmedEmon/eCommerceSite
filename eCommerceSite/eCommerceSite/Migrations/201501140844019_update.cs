namespace eCommerceSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductOrders", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ProductOrders", "ContactNmbr", c => c.String(nullable: false));
            AlterColumn("dbo.ProductOrders", "ProductNumbr", c => c.String(nullable: false));
            AlterColumn("dbo.ProductOrders", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.ProductOrders", "Quentity", c => c.String(nullable: false));
            AlterColumn("dbo.ProductOrders", "Size", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductOrders", "Size", c => c.String());
            AlterColumn("dbo.ProductOrders", "Quentity", c => c.String());
            AlterColumn("dbo.ProductOrders", "Address", c => c.String());
            AlterColumn("dbo.ProductOrders", "ProductNumbr", c => c.String());
            AlterColumn("dbo.ProductOrders", "ContactNmbr", c => c.String());
            AlterColumn("dbo.ProductOrders", "Name", c => c.String());
        }
    }
}
