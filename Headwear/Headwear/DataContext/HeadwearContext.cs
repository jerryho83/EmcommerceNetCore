using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Headwear.Models;
namespace Headwear.DataContext
{
    public class HeadwearContext : DbContext
    {
        public HeadwearContext(DbContextOptions<HeadwearContext> options) : base(options)
        {

        }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderLine> OrderLine { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        //we do not add Cart here because it is like viewmodel

    }
}
