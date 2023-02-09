using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class Shop : BaseDomainEntity
    {
        public Store ShopName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public List<ShopProduct> ShopProducts { get; set; }
    }
}
