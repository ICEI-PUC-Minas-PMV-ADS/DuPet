using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace DuPet.Models
{
    [Table("Doses")]
    public class Vacina : Dose
    {
        [Required]
        public string Fabricante { get; set; }
        [Required]
        public string CrmvMedicoResponsavel { get; set; }
        [Required]
        public string NomeMedicoResponsavel { get; set; }
        [Required]
        public CategoriaDaVacina CategoriaDaVacina { get; set; }
    }

    public enum CategoriaDaVacina
    {
        Obrigatoria,
        Opcional
    }
}
