using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centre.Excellence.Formation.Areas.Inventaire.Models
{
    public class Mobilier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }
        [Required(ErrorMessage = "La quantité est obligatoire"), Display(Name = "Quantité")]
        public int Quantite { get; set; }
        [Required(ErrorMessage = "La localisation du mobilier")]
        public string Localisation { get; set; }
        [Required, EnumDataType(typeof(Etat))]
        public Etat Etat { get; set; }
    }
}
