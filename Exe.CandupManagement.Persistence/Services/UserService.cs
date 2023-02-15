using Exe.CandupManagement.Application.Contracts.Identity;
using Exe.CandupManagement.Application.Models.Identity;
using Exe.CandupManagement.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Persistence.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var customers = await _userManager.GetUsersInRoleAsync("Customer");
            return customers.Select(x => new Customer
            {
                Id = x.Id.ToString(),
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
            }).ToList();
        }
    }
}
