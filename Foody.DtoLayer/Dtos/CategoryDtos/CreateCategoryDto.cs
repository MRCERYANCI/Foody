using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DtoLayer.Dtos.CategoryDtos
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public DateTime CreateCategory { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
