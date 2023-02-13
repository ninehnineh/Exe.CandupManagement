using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Domain.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CitizenIdentityCard { get; set; }
        public string CitizenIdentityCardFrontImage { get; set; }
        public string CitizenIdentityCardBackImage { get; set; }
        public string StudentNumber { get; set; }
        public string StudentCardImage { get; set; }

        public Cart Cart { get; set; }
        public List<UserPaymentInformation> UserPaymentInformation { get; set; }
        public List<Order> Orders { get; set; }
    }
}
