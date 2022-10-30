using System.ComponentModel.DataAnnotations.Schema;

namespace DuPet.Models {
    [Table("PetUsuarios")]
    public class PetUsuarios {

        public int PetId { get; set; }
        public Pet Pet { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
