using CinemaSocial.Data;
using CinemaSocial.Models.DTO;
using CinemaSocial.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CinemaSocial.API;
[Route("api/database")]
[ApiController]
public class DatabaseAPI : ControllerBase
{
    private readonly AppDbContext _appDbContext;
    public DatabaseAPI(AppDbContext appDbContext) {
        _appDbContext = appDbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetProfile() {
        string apiUrl = "https://imdb-top-100-movies1.p.rapidapi.com/";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "8dd015b5eemsh3ce23da4d454321p138e74jsnbd86d1ec8b4f");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com");

            try
            {
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                if (response.IsSuccessStatusCode)
                {

                    string content = response.Content.ReadAsStringAsync().Result;

                    List<MoviesDto> filmesDTO = JsonConvert.DeserializeObject<List<MoviesDto>>(content);
                    List<Movie> filmes = new List<Movie>();

                    foreach (var item in filmesDTO)
                    {
                        Movie? filmeBD = new Movie
                        {
                            IdMovie = Guid.NewGuid(),
                            Title = item.Title,
                            Description = item.Description,
                            Year = item.Year,
                            Rating = item.Rating,
                            ImdbId = item.ImdbId,
                            Link = item.Link,
                            Rank = item.Rank
                        };

                        await _appDbContext.Movies.AddAsync(filmeBD);

                        foreach (var diretorDto in item.Director)
                        {
                            _appDbContext.Directors.Add(new Director
                            {
                                IdMovie = filmeBD.IdMovie,
                                Name = diretorDto,
                                Id = Guid.NewGuid()
                            });
                        }
                        foreach (var starDto in item.Stars)
                        {
                            _appDbContext.Stars.Add(new Star
                            {
                                IdMovie = filmeBD.IdMovie,
                                Name = starDto,
                                Id = Guid.NewGuid()
                            });
                        }
                        foreach (var imagesDto in item.Images)
                        {
                            _appDbContext.Images.Add(new Image
                            {
                                IdMovie = filmeBD.IdMovie,
                                NumberUrl = imagesDto[0],
                                Url = imagesDto[1],
                                Id = Guid.NewGuid()
                            });
                        }
                        foreach (var genreDto in item.Genre)
                        {
                            _appDbContext.Genres.Add(new Genre
                            {
                                IdMovie = filmeBD.IdMovie,
                                Description = genreDto,
                                Id = Guid.NewGuid()
                            });
                        }
                        foreach (var writerDto in item.Writers)
                        {
                            _appDbContext.Writers.Add(new Writer
                            {
                                IdMovie = filmeBD.IdMovie,
                                Name = writerDto,
                                Id = Guid.NewGuid()
                            });
                        }
                    }


                    await _appDbContext.SaveChangesAsync();
                    return Ok("Filmes inseridos com sucesso");
                }
                else
                {
                    return BadRequest("Erro ao chamar a API: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Erro: " + ex.Message);
            }
        }
    }
    
    
}