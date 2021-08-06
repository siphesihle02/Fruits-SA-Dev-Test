namespace Fruits_SA_Devloper_Test.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Fruits_SA_Devloper_Test.Db.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Fruits_SA_Devloper_Test.Db.Database";
        }

        protected override void Seed(Fruits_SA_Devloper_Test.Db.Database context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
