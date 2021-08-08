using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fruits_SA_Devloper_Test.Db;
using System.Data.Entity;

namespace Repositories.Repository
{
   public class productRepository : IproductRepositoty
    {
        public readonly productsDatabase _productsDatabase;
        public productRepository(productsDatabase productDatabase)
        {
            _productsDatabase = productDatabase;
        }
       

        public void DeleteProduct(int id)
        {
            product product = _productsDatabase.Products.Find(id);
            _productsDatabase.Products.Remove(product);
            _productsDatabase.SaveChanges();
        }
        public IEnumerable<product> GetProduct()
        {
            return _productsDatabase.Products.ToList();
        }
        public void InsertProduct(product product)
        {
            _productsDatabase.Products.Add(product);
            _productsDatabase.SaveChanges();
        }
        public void Save()
        {
            _productsDatabase.SaveChanges();
        }

        public void UpdateProduct(product product)
        {

            _productsDatabase.Entry(product).State = EntityState.Modified;
            _productsDatabase.SaveChanges();
        }
    }
}
