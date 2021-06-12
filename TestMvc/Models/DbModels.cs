using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace TestMvc.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required,StringLength(40),Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [Required,Column(TypeName ="money"),Display(Name ="Unite Price"),DisplayFormat(DataFormatString ="{0:0.00}",ApplyFormatInEditMode =true)]
        public decimal UnitePrice { get; set; }
        [Required, Column(TypeName = "money"), Display(Name = "Discount Rate"), DisplayFormat(DataFormatString = "{0:#.##}", ApplyFormatInEditMode = true)]
        public decimal Discount { get; set; }
    }
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}