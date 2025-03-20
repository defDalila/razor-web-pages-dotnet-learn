using Site.Context;
using Site.Models;

namespace Site.Services;

public class LivroService
{
    private readonly EstanteContext _context;
    
    public LivroService(EstanteContext context)
    {
        _context = context;
    }
    
    public IList<Livro> GetLivros()
    {
        if (_context.Livros != null)
        {
            return _context.Livros.ToList();
        }
        else
        {
            return new List<Livro>();
        }
    }
    
    public void AddLivro(Livro livro)
    {
        if (_context.Livros != null)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }
        
    }
    
    public void DeleteLivro( int id)
    {
        if (_context.Livros != null)
        {
            var livro = _context.Livros.Find(id);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }

        }
    }
}
