using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Fruits_SA_Devloper_Test.Models;

namespace Fruits_SA_Devloper_Test.Db
{
   public class Database :DbContext
    {
      public Database():base("Database")
        {

        }
        public DbSet<category> categories { get; set; }
        public DbSet<product> products { get; set; }

    }
}
