using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVC5Rev.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="Product ID")]
        public long ProductID { get; set; }
        [Display(Name = "Name")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name = "Date Purchased")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        [Display(Name = "In stock")]
        public string AvailabilityStatus { get; set; }
        [Display(Name = "Category ID")]
        public Nullable<long> CategoryID { get; set; }
        [Display(Name = "Brand ID")]
        public Nullable<long> BrandID { get; set; }
        [Display(Name = "Active Status")]
        public Nullable<bool> Active { get; set; }
        public string Photo { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
    }
}