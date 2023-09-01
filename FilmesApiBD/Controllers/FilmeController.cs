using Microsoft.AspNetCore.Mvc;
using FilmesApiBD.Models;
namespace FilmesApiBD.Data.Context;

//namespace FilmesApiBD.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private FilmeContext _context;

    public FilmeController(FilmeContext context)
    {
        _context = context;
    }

    //POST
    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperarFilmePorId), new { id = filme.Id }, filme);
    }

    //GET
    [HttpGet]
    //public List<Filme> RecuperarFilme()
    public IEnumerable<Filme> RecuperaFilmes()
    {
        return _context.Filmes;
    }

    //GET 2
    [HttpGet("{id}")]
    public IActionResult RecuperarFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
