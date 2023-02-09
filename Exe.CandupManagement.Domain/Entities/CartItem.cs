using Exe.CandupManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class CartItem : BaseDomainEntity
    {
        public int ProductId { get; set; }
        public int CartId { get; set; }

        public Product Product { get; set; }
        public Cart Cart { get; set; }

    }
}
