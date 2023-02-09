﻿using Exe.CandupManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class OrderItem : BaseDomainEntity
    {
        public int OrderId { get; set; }
        public int ShopProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order Order { get; set; }
        public ShopProduct ShopProduct { get; set; }
    }
}
