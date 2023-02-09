using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class Inventory : BaseDomainEntity
    {
        public int ShopProductId { get; set; }
        public int Quantity { get; set; }
        public InventoryStatus Status { get; set; }

        public List<ShopProduct> ShopProducts { get; set; }
    }
}
