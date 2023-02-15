using Exe.CandupManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe.CandupManagement.Application.DTOs.Product
{
    public class ChangeProductStatusDto : BaseDto
    {
        public bool IsAvailable { get; set; }

    }
}
