using System.ComponentModel.DataAnnotations;

namespace CinemaSocial.Models.ViewModels;

public class SignUpViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a name.")]
    [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters.")]
    public string? Name { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an username.")]
    [StringLength(50, ErrorMessage = "Username cannot be longer than 50 characters.")]
    public string? UserName { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an email.")]
    [EmailAddress(ErrorMessage = "Please provide a valid email.")]
    public string? Email { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a password.")]
    [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters.")]
    public string? Password { get; set; }
    
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please confirm your password.")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string? ConfirmPassword { get; set; }
    
    public bool HasAgreedToTerms { get; set; }
}