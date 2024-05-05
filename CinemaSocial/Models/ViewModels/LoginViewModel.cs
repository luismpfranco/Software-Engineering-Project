using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a username.")]
    public string? UserName { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a password.")]
    public string? Password { get; set; }
}