using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Fruits_SA_Devloper_Test.Models
{
    public class category
    {
        [Key]
        public int categoryId { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(maximumLength:6)]
        [DisplayName("Category Code")]
        public string categoryCode { get; set; }
        [Required]
        public bool isActive { get; set; }
        public virtual ICollection<product> products { get; set; }
    }
}