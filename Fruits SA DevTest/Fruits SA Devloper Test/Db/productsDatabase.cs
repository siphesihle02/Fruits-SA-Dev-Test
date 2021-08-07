using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Fruits_SA_Devloper_Test.Models;

namespace Fruits_SA_Devloper_Test.Db
{
   public class productsDatabase :DbContext
    {
      public productsDatabase():base("productsDatabase")
        {

        }
        public DbSet<category> Categories { get; set; }
        public DbSet<product> Products { get; set; }

    }
}
