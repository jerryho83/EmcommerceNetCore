using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Headwear.Models
{
    [Table("Picture")]
    public class Picture
    {
        public Picture()
        {
            Products = new HashSet<Product>();
        }
        public int PictureId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Picture Product")]
        public string FileName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
