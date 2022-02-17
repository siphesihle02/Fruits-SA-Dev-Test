using System.Data.Entity;
using Fruits_SA_Devloper_Test.Models;
using DownUploadsFiles;

namespace Fruits_SA_Devloper_Test.Db
{
    public class productsDatabase : DbContext
    {
        public productsDatabase() : base("productsDatabase")
        {

        }
        public DbSet<category> Categories { get; set; }
        public DbSet<product> Products { get; set; }
        public DbSet<FileUpload> fileUploads { get; set; }

    }
}
