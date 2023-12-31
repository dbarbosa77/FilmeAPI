﻿using FilmeApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmeApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody]Filme filme)
    {
        filmes.Add(filme);
        Console.WriteLine("Feito a inclusão com sucesso.");
        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
        Console.WriteLine(filme.Genero);
        Console.WriteLine(filme.Id);

    }
}
