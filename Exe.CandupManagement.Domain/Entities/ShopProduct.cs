using Exe.CandupManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class ShopProduct : BaseDomainEntity
    {
        public int ShopId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int views { get; set; }
        public int PopularityScore { get; set; }


        public Product Products { get; set; }
        public Shop Shops { get; set; }
        public List<OrderItem> OrderItem { get; set; }
        public Inventory Inventory { get; set; }
    }
}
