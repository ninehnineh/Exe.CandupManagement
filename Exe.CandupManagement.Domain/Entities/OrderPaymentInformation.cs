using Exe.CandupManagement.Domain.Common;
using Exe.CandupManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class OrderPaymentInformation : BaseDomainEntity
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
        public PaymentStatus Provider { get; set; }

        public Order Order { get; set; }
    }
}
