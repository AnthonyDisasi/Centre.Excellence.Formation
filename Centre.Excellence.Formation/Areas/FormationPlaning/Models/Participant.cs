using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Models
{
    public class Participant
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

        public string NomComplet
        {
            get
            {
                return Nom + " " + Postnom + " " + Prenom;
            }
        }
    }
}
