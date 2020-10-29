using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Areas.FormationPlaning.Models
{
    public class Formations
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required(ErrorMessage = "Le mois est obligatoire")]
        public Mois Mois { get; set; }
        [Required(ErrorMessage = "Le lieux est obligatoire")]
        public string Lieux { get; set; }
        [Required(ErrorMessage = "La semaine est obligatoire")]
        public string Semaine { get; set; }
        [Required(ErrorMessage = "Le cible est obligatoire")]
        public string Cible { get; set; }

        public int Effectif
        {
            get
            {
                return Participants.Count;
            }
        }

        public int Homme
        {
            get
            {
                int i = 0;
                foreach(Participant item in Participants)
                {
                    if(item.Genre == 0)
                    {
                        i++;
                    }
                }
                return i;
            }
        }

        public int Femme
        {
            get
            {
                int i = 0;
                foreach (Participant item in Participants)
                {
                    if (item.Genre != 0)
                    {
                        i++;
                    }
                }
                return i;
            }
        }

        [Display(Name = "Coût de la formation"), Required(ErrorMessage = "Le coût de la formation est obligatoire")]
        public double CoutFormation { get; set; }
        [Required(ErrorMessage = "L'observation est obligatoire")]
        public string Observation { get; set; }


        [Display(Name = "L'année la formation"), Required(ErrorMessage = "L'année la formation est obligatoire")]
        public string Annee { get; set; }

        public ICollection<Former> Formers { get; set; }
        public ICollection<Participant> Participants { get; set; }
    }
}
