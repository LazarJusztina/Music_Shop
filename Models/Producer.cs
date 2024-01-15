namespace Music_Shop.Models
{
    public class Producer
    {
        public int ID { get; set; }
        public string ProducerName { get; set; }
        public ICollection<Song>? Songs { get; set; }
    }
}
