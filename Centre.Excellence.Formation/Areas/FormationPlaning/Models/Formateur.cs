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

        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }

        [Required, EnumDataType(typeof(Genre))]
        public Genre Genre { get; set; }

        public string NiveauEtude { get; set; }
        public int Anciennete { get; set; }


        public string Contact { get; set; }
        public string Adresse { get; set; }
        public string CheminCv { get; set; }
        public string Email { get; set; }

        public ICollection<Modules> Modules { get; set; }
    }
}
