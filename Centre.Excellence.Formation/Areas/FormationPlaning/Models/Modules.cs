using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Models
{
    public class Modules
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string FormarteurID { get; set; }

        [Display(Name = "Intituler"), Required(ErrorMessage = "L'intituler est obligatoire")]
        public string Intituler { get; set; }

        [Display(Name = "Volume"), Required(ErrorMessage = "Le volume est obligatoire")]
        public string Volume { get; set; }

        public Formateur Formateur { get; set; }
    }
}
