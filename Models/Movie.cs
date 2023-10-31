using System.ComponentModel.DataAnnotations;
namespace WebPrueba.Models

{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
		public string Director { get; set; }
		public DateTime DateReleased { get; set; }
    }

}
