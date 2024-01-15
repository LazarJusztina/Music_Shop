using System.Security.Policy;

namespace Music_Shop.Models
{
    public class ProducerIndexData
    {
        public IEnumerable<Producer> Producers { get; set; }
        public IEnumerable<Song> Songs { get; set; }
    }
}
