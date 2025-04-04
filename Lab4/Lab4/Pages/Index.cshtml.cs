using Lab4.ContextModels;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly StiriContext _stiriContext;

        public IndexModel(ILogger<IndexModel> logger, StiriContext stiriContext)
        {
            _logger = logger;
            _stiriContext = stiriContext;
        }

        public IList<Stire> Stiri { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_stiriContext.Stiri != null)
            { 
                Stiri = await _stiriContext.Stiri
                    .Include(s => s.Categorie)
                    .ToListAsync();
            }
        }
    }
}
