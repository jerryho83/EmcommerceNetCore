﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Headwear.Models
{
    [Table("CartItem")]
    public class CartItem
    {
        [Key]
        public int CartId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual Product Products { get; set; }
    }
}
