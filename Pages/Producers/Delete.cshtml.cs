using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Data;
using Music_Shop.Models;

namespace Music_Shop.Pages.Producers
{
    public class DeleteModel : PageModel
    {
        private readonly Music_Shop.Data.Music_ShopContext _context;

        public DeleteModel(Music_Shop.Data.Music_ShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Producer Producer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Producer == null)
            {
                return NotFound();
            }

            var producer = await _context.Producer.FirstOrDefaultAsync(m => m.ID == id);

            if (producer == null)
            {
                return NotFound();
            }
            else 
            {
                Producer = producer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Producer == null)
            {
                return NotFound();
            }
            var producer = await _context.Producer.FindAsync(id);

            if (producer != null)
            {
                Producer = producer;
                _context.Producer.Remove(Producer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
