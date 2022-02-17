using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fruits_SA_Devloper_Test.Models;

namespace Repositories.Repository
{
    // The aim was to refactor the CRUD operations to use repositories to access data source i did not finish.
    public interface IcategoryRepository:IDisposable
    {
        IEnumerable<category> GetCategories();
        void InsertCategory (category category);
        void DeleteCategory(int categoryId);
        void UpdateCategory(category category);
        void Save();
    }
}
