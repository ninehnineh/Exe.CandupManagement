using Exe.CandupManagement.Application.DTOs.Category;
using Exe.CandupManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product
{
    public class ProductDto : BaseDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
        public bool IsAvailable { get; set; }

    }
}
