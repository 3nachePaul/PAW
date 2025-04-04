using Lab4.ContextModels;
using Lab4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Pages
{
    public class StireModel : PageModel
    {
        private readonly StiriContext _stiriContext;

        public StireModel(StiriContext stiriContext)
        {
            _stiriContext = stiriContext;
        }

        public Stire Stire { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int stireId)
        {
            if (_stiriContext.Stiri == null)
            {
                return RedirectToPage("./Error");
            }

            var stire = await _stiriContext.Stiri
                .Include(s => s.Categorie)
                .FirstOrDefaultAsync(s => s.Id == stireId);

            if (stire == null)
            {
                return RedirectToPage("./Error");
            }

            Stire = stire;
            return Page();
        }
    }
}
