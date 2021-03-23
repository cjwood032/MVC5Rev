using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace MVC5Rev.Models
{
    public class Brand
    {
        [Key]
        [Display(Name = "Brand ID")]
        public long BrandID { get; set; }
        [Display(Name = "Brand Name")]
        public string BrandName { get; set; }
    }
}