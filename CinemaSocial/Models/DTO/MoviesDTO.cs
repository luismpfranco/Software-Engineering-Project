namespace CinemaSocial.Models.DTO
{
    public class MoviesDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public List<string> Director { get; set; }
        public List<string> Writers { get; set; }
        public List<string> Stars { get; set; }
        public List<string> Genre { get; set; }
        public List<List<string>> Images { get; set; }
        public string ImdbId { get; set; }
        public int Rank { get; set; }
        public string Rating { get; set; }
        public string Year { get; set; }

    }
}
