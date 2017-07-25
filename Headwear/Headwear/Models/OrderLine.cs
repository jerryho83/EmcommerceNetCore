﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Headwear.Models
{
    [Table("OrderLine")]
    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? Price { get; set; }
        public int? OrderId { get; set; }
        public int ProductId { get; set; }
        public virtual Order Orders { get; set; }
        public virtual Product Products { get; set; }
    }
}
