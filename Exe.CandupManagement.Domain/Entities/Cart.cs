using Exe.CandupManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class Cart : BaseDomainEntity
    {
        public int UserId { get; set; }
        public int Status { get; set; }
        public string Session { get; set; }


        public List<CartItem> CartItems { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}
