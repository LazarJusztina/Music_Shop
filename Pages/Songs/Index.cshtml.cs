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
    public class IndexModel : PageModel
    {
        private readonly Music_Shop.Data.Music_ShopContext _context;

        public IndexModel(Music_Shop.Data.Music_ShopContext context)
        {
            _context = context;
        }

        public IList<Song> Song { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Song != null)
            {
                Song = await _context.Song
                    .Include(b => b.Producer)
                    .ToListAsync();
            }
        }
    }
}
