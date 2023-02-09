using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class Product : BaseDomainEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<ShopProduct> ShopProducts { get; set; }
        public Discount Discount { get; set; }
        public List<CartItem> CartItems { get; set; }

    }
}
