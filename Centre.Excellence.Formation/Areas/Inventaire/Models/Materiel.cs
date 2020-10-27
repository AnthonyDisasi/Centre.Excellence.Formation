using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentreFormation.Areas.Inventaire.Models
{
    public class Materiel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Display(Name = "Description des Fourniture"), Required(ErrorMessage = "La description est obligatoire")]
        public string Description { get; set; }
        [Display(Name = "Quantité"), Required(ErrorMessage = "La quantité est obligatoire")]
        public int Quatite { get; set; }
        [Required(ErrorMessage = "La marque est obligatoire")]
        public string Marque { get; set; }
        [Display(Name = "Carecteristique"), Required(ErrorMessage = "Le carecteristique est obligatoire")]
        public string Carecteristique { get; set; }
        [Display(Name = "Numéro de série"), Required(ErrorMessage = "Le numéro de série est obligatoire")]
        public string NumeroSerie { get; set; }
        [Display(Name = "TAG"), Required(ErrorMessage = "Le TAG est obligatoire")]
        public string TAG { get; set; }
        [Display(Name = "Autre Numéro"), Required(ErrorMessage = "L'autre Numéro est obligatoire")]
        public string AutreNumero { get; set; }
        [ Required(ErrorMessage = "La localisation est obligatoire")]
        public string Localisation { get; set; }
        [Required(ErrorMessage = "Le fournisseur est obligatoire")]
        public string Fournisseur { get; set; }
        [Display(Name = "Source de financement"), Required(ErrorMessage = "La source de financement est obligatoire")]
        public string SourceFinancement { get; set; }
        [Display(Name = "Année d'acquisition"), Required(ErrorMessage = "L'année d'acquisition est obligatoire")]
        public string AnneeAcquisition { get; set; }
        [Required(ErrorMessage = "Le Commentaire est obligatoire")]
        public string Commentaire { get; set; }

        public ICollection<Diagnostique> Diagnostiques { get; set; }
    }
}
