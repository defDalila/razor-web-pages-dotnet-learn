using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site.Models;

namespace Site.Context;

public class EstanteContext :DbContext
{
    public EstanteContext(DbContextOptions<EstanteContext> options) : base(options)
    {
        
    }
    
    public DbSet<Livro> Livros { get; set; }
    
}
