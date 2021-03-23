using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC5Rev.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="Product ID")]
        public long ProductID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage="Product Name cannot be blank")]
        [MaxLength(40,ErrorMessage ="Name cannot be more than 40 characters")]
        [MinLength(2, ErrorMessage = "Name must be more than a single character")]
        public string ProductName { get; set; }
        [Display(Name = "Price")]
        [Required]
        [Range(0,10000, ErrorMessage ="Price needs to be a positive value less than 10,000")]
        public Nullable<decimal> Price { get; set; }
        [Display(Name = "Date Purchased")]
        
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        [Display(Name = "In stock")]
        public string AvailabilityStatus { get; set; }
        [Display(Name = "Category ID")]
        [Required]
        public Nullable<long> CategoryID { get; set; }
        [Display(Name = "Brand ID")]
        [Required]
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