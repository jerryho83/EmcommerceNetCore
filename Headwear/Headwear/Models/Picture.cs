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
      
        public int PictureId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Picture Product")]
        public string FileName { get; set; }
      
    }
}
