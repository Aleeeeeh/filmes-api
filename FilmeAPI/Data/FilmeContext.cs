﻿using FilmeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmeAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> context) : base(context)
    {

    }

    public DbSet<Filme> Filmes { get; set; }
}
