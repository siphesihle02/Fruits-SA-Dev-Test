using Fruits_SA_Devloper_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fruits_SA_Devloper_Test.Db;
using System.Data.Entity;

namespace Repositories.Repository
{
 
    public class categoryRepository : IcategoryRepository
{
        public readonly productsDatabase _productsDatabase;
        public categoryRepository(productsDatabase productDatabase)
        {
            _productsDatabase = productDatabase;
        }
          
        public void DeleteCategory(int categoryId)
    {
            category category = _productsDatabase.Categories.Find(categoryId);
            _productsDatabase.Categories.Remove(category);
            _productsDatabase.SaveChanges();
        }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<category> GetCategories()
    {
            return _productsDatabase.Categories.ToList();
    }

    public void InsertCategory(category category)
    {
            _productsDatabase.Categories.Add(category);
            _productsDatabase.SaveChanges();
        }

    public void Save()
    {
            _productsDatabase.SaveChanges();
      }

    public void UpdateCategory(category category)
    {

            _productsDatabase.Entry(category).State = EntityState.Modified;
            _productsDatabase.SaveChanges();
        }
}
}
