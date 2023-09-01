using Microsoft.EntityFrameworkCore;
using FilmesApiBD.Models;

namespace FilmesApiBD.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {

        }
        public DbSet<Filme> Filmes { get; set; }
    }
    
}
