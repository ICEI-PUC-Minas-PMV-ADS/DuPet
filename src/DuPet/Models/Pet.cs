using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DuPet.Models
{
    [Table("Pets")]
    public class Pet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required, Column(TypeName ="decimal(18,2)")]
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        [Required]
        public char Sexo { get; set; }
        [Required]
        public string Pelagem { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }

        public ICollection<Dose> Doses { get; set; }

        public ICollection<PetUsuarios> Usuarios { get; set; }

    }
}
