using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReposicaoAula.Models
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public Genero? Genre { get; set; }
        public Videogame? Videogame { get; set; }
    }
}
