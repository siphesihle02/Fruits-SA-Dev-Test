using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fruits_SA_Devloper_Test.Models;

namespace Repositories.Repository
{
    // The aim was to refactor the CRUD operations to use repositories to access data source i did not finish.
    public interface IproductRepositoty:IDisposable
    {
        IEnumerable<product> GetProducts();
        void InsertProduct(product product);
        void DeleteProduct(int id);
        void UpdateProduct(product product);
        void Save();
    }
}
