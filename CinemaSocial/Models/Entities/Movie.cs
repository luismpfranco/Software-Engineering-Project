using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        public Guid IdMovie { get; set; }
        //public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public ICollection<Director> Director { get; set; }
        public ICollection<Writer> Writers { get; set; }
        public ICollection<Star> Stars { get; set; }
        public ICollection<Genre> Genre { get; set; }
        public ICollection<Image> Images { get; set; }
        public string ImdbId { get; set; }
        public int Rank { get; set; }
        public string Rating { get; set; }
        public string Year { get; set; }
        
        public Movie()
        {
            Director = new List<Director>();
            Writers = new List<Writer>();
            Stars = new List<Star>();
            Genre = new List<Genre>();
            Images = new List<Image>();
        }
    }
}
