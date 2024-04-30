using Microsoft.AspNetCore.Mvc;

namespace CinemaSocial.API;
[Route("api/database")]
[ApiController]
public class DatabaseAPI : ControllerBase
{
    //IUnitOfWork UnitOfWork;

    public DatabaseAPI(/*IUnitOfWork unitOfWork*/) {
        //this.UnitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult GetProfile() {
        // URL do endpoint da API
        string apiUrl = "https://imdb-top-100-movies1.p.rapidapi.com/movie/generate";

        using (HttpClient client = new HttpClient())
        {
            // Adiciona os cabeçalhos necessários
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "8dd015b5eemsh3ce23da4d454321p138e74jsnbd86d1ec8b4f");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "imdb-top-100-movies1.p.rapidapi.com");

            try
            {
                // Faz a chamada à API
                HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                // Verifica se a resposta foi bem-sucedida
                if (response.IsSuccessStatusCode)
                {
                    // Lê o conteúdo da resposta
                    string content = response.Content.ReadAsStringAsync().Result;
                    return Ok(content);
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