using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Le mail est obligatoire")]
        [UIHint("email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Le mot de passe est obligatoire")]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
