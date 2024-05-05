using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaSocial.Models.Entities;

[Table("user_account")]
public class UserAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("name")]
    [MaxLength(100)]
    public string? Name { get; init; }
    
    [Column("username")]
    [MaxLength(100)]
    public string? UserName { get; init; }
    
    [Column("email")]
    [MaxLength(100)]
    public string? Email { get; init; }
    
    [Column("password")]
    [MaxLength(100)]
    public string? Password { get; init; }
    
    [Column("role")]
    [MaxLength(20)]
    public string? Role { get; init; }
    
    [Column("salt")]
    [MaxLength(100)]
    public string? Salt { get; init; }
    
    public ICollection<Review> Reviews { get; set; }
}