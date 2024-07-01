using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
