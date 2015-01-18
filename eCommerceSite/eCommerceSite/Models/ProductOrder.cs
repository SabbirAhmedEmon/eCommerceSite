using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace eCommerceSite.Models
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }
        [Required]
        [Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Your Contacr Number")]
        public string ContactNmbr { get; set; }
        [Required]
        [Display(Name = "Product Code")]
        public string ProductNumbr { get; set; }
        [Required]
        [Display(Name = "Your Address")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Product Quentity")]
        public string Quentity { get; set; }
        [Required]
        [Display(Name = "Product Size")]
        public string  Size { get; set; }

    }
}