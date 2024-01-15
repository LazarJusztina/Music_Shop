namespace Music_Shop.Models
{
    public class SongCategory
    {
        public int ID { get; set; }
        public int SongID { get; set; }
        public Song Song { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
