using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string CitizenIdentityCard { get; set; }
        public string CitizenIdentityCardFrontImage { get; set; }
        public string CitizenIdentityCardBackImage { get; set; }
        public string StudentNumber { get; set; }
        public string StudentCardImage { get; set; }


    }
}
