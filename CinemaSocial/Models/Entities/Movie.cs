using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        public Guid IdMovie { get; init; }
        public string? Title { get; init; }
        public string Description { get; init; }
        public string Link { get; init; }
        public ICollection<Director> Director { get; init; }
        public ICollection<Writer> Writers { get; init; }
        public ICollection<Star> Stars { get; init; }
        public ICollection<Genre> Genre { get; init; }
        public ICollection<Image> Images { get; init; }
        public string ImdbId { get; init; }
        public int Rank { get; init; }
        public string Rating { get; init; }
        public string Year { get; init; }
        public ICollection<Review> Reviews { get; init; }
        
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
