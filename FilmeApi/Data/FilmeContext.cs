using FilmeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeApi.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
    {
        
    }

    public DbSet<Filme> Filmes { get; set; }

}
