using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centre.Excellence.Formation.Areas.Inventaire.Models
{
    public class Fourniture
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }
        public string Nom { get; set; }
    }
}
