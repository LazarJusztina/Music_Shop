using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Data;
using Music_Shop.Models;

namespace Music_Shop.Pages.Producers
{
    public class IndexModel : PageModel
    {
        private readonly Music_Shop.Data.Music_ShopContext _context;

        public IndexModel(Music_Shop.Data.Music_ShopContext context)
        {
            _context = context;
        }

        public IList<Producer> Producer { get;set; } = default!;
        public ProducerIndexData ProducerData { get; set; }
        public int ProducerID { get; set; }
        public int SongID { get; set; }
        public async Task OnGetAsync( int? id, int? songID )
        {
            ProducerData = new ProducerIndexData();
            ProducerData.Producers = await _context.Producer
           .Include(i => i.Songs)
           .OrderBy(i => i.ProducerName)
           .ToListAsync();
            if (id != null)
            {
                ProducerID = id.Value;
                Producer producer = ProducerData.Producers
               .Where(i => i.ID == id.Value)
               .Single();
                ProducerData.Songs = producer.Songs;
            }
        }
    }
}
