using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Data
{
   public class Category
    {
        [Key]
        public int categoryId { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a unique category code")]
        [DisplayName("Category Code")]
        public string categoryCode { get; set; }
        [Required]
        public bool isActive { get; set; }

    }
}
