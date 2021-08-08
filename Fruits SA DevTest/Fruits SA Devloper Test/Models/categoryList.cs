using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Fruits_SA_Devloper_Test.Models
{
    public class categoryList
    {
        [Required]
        [Display(Name = "Email Address")]
        public string categoryName { get; set; }
        public IEnumerable<SelectListItem> categoryNameList { get; set; }
        
           
        }
}