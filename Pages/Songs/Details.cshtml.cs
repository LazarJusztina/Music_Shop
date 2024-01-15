using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Data;
using Music_Shop.Models;

namespace Music_Shop.Pages.Songs
{
    public class DetailsModel : PageModel
    {
        private readonly Music_Shop.Data.Music_ShopContext _context;

        public DetailsModel(Music_Shop.Data.Music_ShopContext context)
        {
            _context = context;
        }

      public Song Song { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Song == null)
            {
                return NotFound();
            }

            var song = await _context.Song.FirstOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }
            else 
            {
                Song = song;
            }
            return Page();
        }
    }
}
