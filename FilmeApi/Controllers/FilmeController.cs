using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 1;


    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        Console.WriteLine($"Feito a inclusão do filme {filme.Titulo} de id {filme.Id} com sucesso.");
        return CreatedAtAction(nameof(RecuperaFilme), new { id = filme.Id }, filme);

    }

    [HttpGet]
    public IEnumerable<Filme> ListarFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]

    public IActionResult RecuperaFilme(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}
