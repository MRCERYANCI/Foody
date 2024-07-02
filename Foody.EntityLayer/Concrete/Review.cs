using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.EntityLayer.Concrete
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerTitle { get; set; }
        public string CustomerImage { get; set; }
        public string CustomerComment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
    }
}
