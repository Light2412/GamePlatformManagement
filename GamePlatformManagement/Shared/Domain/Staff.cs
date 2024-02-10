using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatformManagement.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$", ErrorMessage = "Contact Number is not valid")]
        public string? ContactNumber { get; set; }
        
        public string? Password { get; set; }
        
        

    }
}
