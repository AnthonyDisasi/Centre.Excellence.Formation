using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Centre.Excellence.Formation.Areas.Inventaire.Models
{
    public class Diagnostique
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string MaterielID { get; set; }

        [Display(Name = "Description du diagnostique"), Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }
        [Display(Name = "Quantité"), Required(ErrorMessage = "La quantité est obligatoire")]
        public int Quatite { get; set; }
        [Display(Name = "Etat"), Required(ErrorMessage = "L'état est obligatoire"), EnumDataType(typeof(Etat))]
        public Etat Etat { get; set; }
        [Display(Name = "Besoin du materiel"), Required(ErrorMessage = "Le besoin est obligatoire")]
        public string Besoin { get; set; }
        [Display(Name = "Date du diagnostique"), DataType(DataType.Date), Required(ErrorMessage = "La date est obligatoire")]
        public DateTime DateDiagnostique { get; set; }

        public Materiel Materiel { get; set; }
    }
}
