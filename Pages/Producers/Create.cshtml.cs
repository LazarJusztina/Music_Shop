using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Music_Shop.Data;
using Music_Shop.Models;

namespace Music_Shop.Pages.Producers
{
    public class CreateModel : PageModel
    {
        private readonly Music_Shop.Data.Music_ShopContext _context;

        public CreateModel(Music_Shop.Data.Music_ShopContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Producer Producer { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Producer == null || Producer == null)
            {
                return Page();
            }

            _context.Producer.Add(Producer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
