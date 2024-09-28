namespace ReposicaoAula.Data;
using ReposicaoAula.Models;
using Microsoft.EntityFrameworkCore;
using ReposicaoAula.Data;
using System.Collections.Generic;

public class ConnectionContext : DbContext
{
    public DbSet<Jogo> Jogos { get; set; }
    public DbSet<Videogame> Videogames { get; set; }

    public DbSet<Genero> Generos { get; set; }

    public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options) { }
}
