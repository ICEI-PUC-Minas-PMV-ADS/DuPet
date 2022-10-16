using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DuPet.Models {
    public class UsuarioDto {
        public int? Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public Perfil Perfil { get; set; }
    }
}
