using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site.Models;

public class Livro
{
    public int Id { get; set; }
    public required string Titulo { get; set; }    
    public string? Autor { get; set; }
    public string? Genero { get; set; }
    public string? Editora { get; set; }
    public int TotalPaginas { get; set; }
    public DateOnly DataPublicacao { get; set; }
    public double Avaliacao { get; set; }
}
