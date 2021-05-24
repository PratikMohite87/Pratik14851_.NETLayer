using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 

namespace MVCWebApp1.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(15, ErrorMessage = "Max length should be 7 characters")]
        public string GuestName { set; get; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage ="Not valid email")]
        public string GuestEmail { set; get; }

        [Required(ErrorMessage = "Phone is required")]
        [Phone(ErrorMessage ="Not valid phone no")]
        public string GuestPhone { set; get; }

        [Required(ErrorMessage = "Decision is required")]
        public string GuestDecision { set; get; }
    }
}
