using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReposicaoAula.Models
{
    [Table("Generos")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Genre { get; set; } = string.Empty;
    }
}
