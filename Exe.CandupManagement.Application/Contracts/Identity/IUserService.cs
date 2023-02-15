using Exe.CandupManagement.Application.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.Contracts.Identity
{
    public interface IUserService
    {
        Task<List<Customer>> GetEmployees();
    }
}
