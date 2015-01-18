using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace eCommerceSite.Models
{
    public class AllDbContext:DbContext
    {
        public DbSet<AllProducts> AllProductseDbSet { get; set; }
        public DbSet<MensProduct> MensProductDbSet { get; set; }
        public DbSet<ProductOrder> ProductOrderDbSet { get; set; }

        //public AllDbContext()
        //    : base("name=AllDbContext")
        //{

        //}
    }
}