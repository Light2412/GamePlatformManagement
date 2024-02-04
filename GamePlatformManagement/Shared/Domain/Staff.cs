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
        [RegularExpression(@"(6|8|9)\d(7)", ErrorMessage = "Contact Number is not a valid phone number")]
        public string? ContactNumber { get; set; }
        

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[@$!%*?&])",
        ErrorMessage = "Password must contain one lower case letter and one special character.")]
        public string? Password { get; set; }
        
        

    }
}
