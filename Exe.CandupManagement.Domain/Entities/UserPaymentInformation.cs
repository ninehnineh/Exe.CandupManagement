using Exe.CandupManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class UserPaymentInformation : BaseDomainEntity
    {
        public int UserId { get; set; }
        public string CardNumber { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Cvv { get; set; }

        public ApplicationUser AppUser { get; set; }

    }
}
