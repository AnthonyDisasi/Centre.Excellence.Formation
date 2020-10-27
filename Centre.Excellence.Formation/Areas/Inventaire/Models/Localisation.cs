using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centre.Excellence.Formation.Areas.Inventaire.Models
{
    public class Localisation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string Nom { get; set; }
    }
}
