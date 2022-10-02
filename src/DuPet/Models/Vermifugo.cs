using System.ComponentModel.DataAnnotations.Schema;

namespace DuPet.Models
{
    [Table("Doses")]
    public class Vermifugo: Dose
    {
        public int QtdeMg { get; set; }
    }
}
