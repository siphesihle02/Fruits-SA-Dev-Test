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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.categories");
        }
    }
}
