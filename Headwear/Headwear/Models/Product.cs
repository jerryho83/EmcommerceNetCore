using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Headwear.Models
{
    [Table("Product")]
    public class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            OrderLines = new HashSet<OrderLine>();
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Detail { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public byte[] ProductImagePath { get; set; }
        public int CartId { get; set; }
        public int CategoryId { get; set; }
        public int OrderLineId { get; set; }
        public int PictureId { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual Category Categories { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
