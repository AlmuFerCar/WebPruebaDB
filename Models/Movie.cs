using Microsoft.EntityFrameworkCore;

namespace WebPrueba.Models

{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
		public string Director { get; set; }
		public DateTime DateReleased { get; set; }
    }

}
