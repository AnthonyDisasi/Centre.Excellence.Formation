using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Models
{
    public class Formateur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Display(Name = "Nom"), Required(ErrorMessage = "Le nom est obligatoire")]
        public string Nom { get; set; }
        [Display(Name = "Postnom"), Required(ErrorMessage = "Le postnom est obligatoire")]
        public string Postnom { get; set; }
        [Display(Name = "Prenom"), Required(ErrorMessage = "Le prenom est obligatoire")]
        public string Prenom { get; set; }

        [Required, EnumDataType(typeof(Genre))]
        public Genre Genre { get; set; }

        [Display(Name = "Niveau d'étude"), Required(ErrorMessage = "Le niveau d'étude est obligatoire")]
        public string NiveauEtude { get; set; }
        [Display(Name = "Ancienneté"), Required(ErrorMessage = "L'ancienneté est obligatoire")]
        public string Anciennete { get; set; }


        [Display(Name = "Contact"), Required(ErrorMessage = "Le contact est obligatoire")]
        public string Contact { get; set; }
        [Display(Name = "Adresse"), Required(ErrorMessage = "L'adresse est obligatoire")]
        public string Adresse { get; set; }
        [Display(Name = "CV"), Required(ErrorMessage = "Le CV est obligatoire")]
        public string CheminCv { get; set; }
        [Display(Name = "E-mail"), Required(ErrorMessage = "L'e-mail est obligatoire"), DataType(DataType.EmailAddress, ErrorMessage = "Veuillez saisir une adresse mail")]
        public string Email { get; set; }

        public string NomComplet
        {
            get
            {
                return Nom + " " + Postnom + " " + Prenom;
            }
        }

        public ICollection<Modules> Modules { get; set; }
    }
}
