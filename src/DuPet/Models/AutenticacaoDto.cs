using System.ComponentModel.DataAnnotations;

namespace DuPet.Models {
    public class AutenticacaoDto {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Senha { get; set; }
    }
}
