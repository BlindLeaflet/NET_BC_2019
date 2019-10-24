using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models
{
    public class UserModel:RegisteredUserModel
    {
        
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.EmailAddress)]
        [Compare(nameof(Email))]
        public string EmailRepeat { get; set; }        
        [Required(ErrorMessage = "Required field")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string PasswordRepeat { get; set; }

    }
}
