using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fruits_SA_Devloper_Test.Models;

namespace Repositories.Repository
{
    public interface IcategoryRepository:IDisposable
    {
        IEnumerable<category> GetCategories();
        void InsertCategory (category category);
        void DeleteCategory(int categoryId);
        void UpdateCategory(category category);
        void Save();
    }
}
