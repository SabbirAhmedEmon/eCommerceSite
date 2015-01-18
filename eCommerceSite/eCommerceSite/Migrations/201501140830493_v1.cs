namespace eCommerceSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllProducts",
                c => new
                    {
                        AllProductsId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AllProductsId);
            
            CreateTable(
                "dbo.MensProducts",
                c => new
                    {
                        MensProductId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MensProductId);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        ProductOrderId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContactNmbr = c.String(),
                        ProductNumbr = c.String(),
                        Address = c.String(),
                        Quentity = c.String(),
                        Size = c.String(),
                    })
                .PrimaryKey(t => t.ProductOrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductOrders");
            DropTable("dbo.MensProducts");
            DropTable("dbo.AllProducts");
        }
    }
}
