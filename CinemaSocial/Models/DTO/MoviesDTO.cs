namespace CinemaSocial.Models.DTO
{
    public abstract class MoviesDto(
        string? title,
        string description,
        string link,
        List<string> director,
        List<string> writers,
        List<string> stars,
        List<string> genre,
        List<List<string>> images,
        string imdbId,
        string rating,
        string year,
        int rank)
    {
        public string? Title { get; } = title;
        public string Description { get; } = description;
        public string Link { get; } = link;
        public List<string> Director { get; } = director;
        public List<string> Writers { get; } = writers;
        public List<string> Stars { get; } = stars;
        public List<string> Genre { get; } = genre;
        public List<List<string>> Images { get; } = images;
        public string ImdbId { get; } = imdbId;
        public int Rank { get; } = rank;
        public string Rating { get; } = rating;
        public string Year { get; } = year;
    }
}
