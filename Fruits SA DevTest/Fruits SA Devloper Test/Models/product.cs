using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace Fruits_SA_Devloper_Test.Models
{
    public class product
    {
        [Key]
     public int id { get; set; }
     public string productCode { get; set; }
     public string productName { get; set; }
     public string description { get; set; }
     public int categoryId { get; set; }
     public virtual category Category { get; set; }
    }
}