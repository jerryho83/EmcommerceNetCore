using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Headwear.Models
{
    [Table("Cart")]
    public class Cart
    {
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
        public virtual List<CartItem> CartItems { get; set; }
    }
}
