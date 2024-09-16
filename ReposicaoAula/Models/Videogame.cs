using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReposicaoAula.Models
{
    [Table("Videogames")]
    public class Videogame
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }

    }
}
