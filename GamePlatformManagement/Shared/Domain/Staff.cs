using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatformManagement.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? ContactNumber { get; set; }
        public string? Password { get; set; }
    }
}
