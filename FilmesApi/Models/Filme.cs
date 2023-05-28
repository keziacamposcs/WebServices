using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models

/*  
    Verificando em tempo real de execução se está retornando valor NULO
    Basta fazer um [DataAnnotation]: Ex [Required] ou [StringLength(100)]
*/
{
    public class Filme
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int Duracao { get; set; }
    }
}
