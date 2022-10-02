using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace DuPet.Models
{
    [Table("Doses")]
    public class Dose
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomeDaAplicacao { get; set; }
        [Required]
        public DateTime DataDaAplicacao { get; set; }
        public int ControleDeDose { get; set; }
        [Required]
        public TipoDeDose TipoDeDose { get; set; }
        [Required]
        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }

    public enum TipoDeDose
    {
        Vacina,
        Vermifugo
    }
}
