using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlatformManagement.Shared.Domain
{
    public class Game : BaseDomainModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title does not meet length requirements")]
        public string? Title { get; set; }

        [Required]
        public string? AgeGroup { get; set; }

        [Required]
        public string? Description { get; set; }
        
        [Required]
        public string? Genre { get; set; }

        [Required]
        public double Price { get; set; }
        

    }
}
