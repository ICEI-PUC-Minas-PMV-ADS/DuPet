using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuPet.Models
{
    [Table("Doses")]
    public class Vermifugo : Dose
    {
        [Key]
        public int IdVerm { get; set; }
        public int QtdeMg { get; set; }
        [Required]
        public int QtdeComp { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
    }
}
