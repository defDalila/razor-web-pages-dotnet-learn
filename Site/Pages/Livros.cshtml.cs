using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Site.Models;
using Site.Services;

namespace Site.Pages
{
    public class LivrosModel : PageModel
    {
        private readonly LivroService _service;
        public IList<Livro> ListaLivros { get; set; } = default!;
        
        public LivrosModel(LivroService service)
        {
            _service = service;
        }
        
        public void OnGet()
        {
            ListaLivros = _service.GetLivros();
        }
        
    }
}
