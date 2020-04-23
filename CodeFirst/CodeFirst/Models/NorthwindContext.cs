using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class NorthwindContext:DbContext
    {
        public NorthwindContext()
            :base("name=NorthwindConnection")
        {

        }
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> productsTable { get; set; }
    }
}