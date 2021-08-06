namespace Fruits_SA_Devloper_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.categories", "categoryCode", c => c.String(nullable: false, maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.categories", "categoryCode", c => c.String(nullable: false));
        }
    }
}
