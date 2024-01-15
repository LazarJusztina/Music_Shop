namespace Music_Shop.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<SongCategory>? SongCategories { get; set; }

    }
}
