using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityDemoApp_2.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        public string UserName { set; get; }

        [Required]
        public string Password { set; get; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { set; get; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { set; get; }

        [Required]
        public string FullName { set; get; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { set; get; }
    }
}
