using Exe.CandupManagement.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product
{
    public class SearchProductByNameDto
    {
        public string ProductName { get; set; }
        public PagedRequest PagedRequest{ get; set; }
    }
}
