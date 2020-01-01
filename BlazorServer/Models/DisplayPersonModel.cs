using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BlazorServer.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "First Name is too long")]
        [MinLength(1, ErrorMessage = "First Name is too short")]
        public string FirstName { get; set; }

        [StringLength(15, ErrorMessage = "Last Name is too long")]
        [MinLength(1, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
