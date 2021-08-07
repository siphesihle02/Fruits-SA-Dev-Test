namespace Fruits_SA_Devloper_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        categoryCode = c.String(nullable: false),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        productCode = c.String(nullable: false),
                        productName = c.String(nullable: false),
                        description = c.String(),
                        categoryName = c.String(nullable: false),
                        price = c.Double(nullable: false),
                        image = c.Binary(),
                        Category_categoryId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.categories", t => t.Category_categoryId)
                .Index(t => t.Category_categoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "Category_categoryId", "dbo.categories");
            DropIndex("dbo.products", new[] { "Category_categoryId" });
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
