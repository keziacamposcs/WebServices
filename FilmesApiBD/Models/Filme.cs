using System.ComponentModel.DataAnnotations;

namespace FilmesApiBD.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Duracao { get; set; }
    }
}
