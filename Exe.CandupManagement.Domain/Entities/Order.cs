using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class Order : BaseDomainEntity
    {
        public int UserId { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderPaymentInformation> OrderPaymentInformation { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}
