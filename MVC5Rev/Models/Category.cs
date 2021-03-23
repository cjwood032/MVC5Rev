using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC5Rev.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        public long CategoryID { get; set; }
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }
}