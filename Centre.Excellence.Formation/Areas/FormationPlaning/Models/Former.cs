using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Models
{
    public class Former
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string FormateurID { get; set; }
        public string FormationsID { get; set; }

        public Formateur Formateur { get; set; }
        public Formations Formation { get; set; }
    }
}
