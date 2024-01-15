using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music_Shop.Models;

namespace Music_Shop.Data
{
    public class Music_ShopContext : DbContext
    {
        public Music_ShopContext (DbContextOptions<Music_ShopContext> options)
            : base(options)
        {
        }

        public DbSet<Music_Shop.Models.Song> Song { get; set; } = default!;

        public DbSet<Music_Shop.Models.Producer>? Producer { get; set; }
    }
}
