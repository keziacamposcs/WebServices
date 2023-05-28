using Microsoft.AspNetCore.Mvc;
using FilmesApi.Models;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]

public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;

    /*
    //POST
    [HttpPost]
    public void AdicionarFilme([FromBody] Filme filme)
    {
        //Verificando se está retornando valor NULO para a classe após o envio
        if (!string.IsNullOrEmpty(filme.Titulo))
        {
            filme.Id = ++id;
            filmes.Add(filme);

            CreatedAtAction(nameof(RecuperarFilmePorId), new {id = filme.Id}, filme);

            //Para verificar se está retornando, é retornado para o console - Console.WriteLine(NomeDaClasse.NomeDoDado);
            //Console.WriteLine(filme.Titulo);
            //Console.WriteLine(filme.Genero);
            //Console.WriteLine(filme.Duracao);
        }
    }
    */

    //POST
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperarFilmePorId), new {id = filme.Id}, filme);
    }

    //GET
    [HttpGet]
    //public List<Filme> RecuperarFilme()
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return filmes;
    }

    //GET 2
    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok();
    }
}
