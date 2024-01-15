using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Music_Shop.Models
{
    public class Song
    {
        public int ID { get; set; }
        [Display(Name = "Song Title")]
        public string Title { get; set; }
        public string Singer { get; set; }
        public int? ProducerID { get; set; }
        public Producer? Producer { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public ICollection<SongCategory>? SongCategories { get; set; }
    }
}
