using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Models
{
    public class CreateModel
    {
        [Required(ErrorMessage = "Le nom est obligatoire"), Display(Name = "Nom de l'ustisateur")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Le mail est obligatoire"), Display(Name = "E-mail de l'ustisateur")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Le mot de passe est obligatoire"), Display(Name = "Mot de passe de l'ustisateur")]
        public string Password { get; set; }
    }
}
