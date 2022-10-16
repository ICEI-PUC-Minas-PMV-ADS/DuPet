using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DuPet.Models {
    [Table("Usuarios")]
    public class Usuario {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public Perfil Perfil { get; set; }

        public ICollection<PetUsuarios> Pets { get; set; }

    }
    public enum Perfil {
        [Display(Name = "Administrador")]
        Administrador,
        [Display(Name = "Usuario")]
        Usuario

    }

}
