using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security;
using CinemaSocial.Data;

namespace CinemaSocial.Models.Entities;

[Table("user_account")]
public class UserAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string? Name { get; set; }
    
    [Column("username")]
    [MaxLength(100)]
    public string? UserName { get; set; }
    
    [Column("email")]
    [MaxLength(100)]
    public string? Email { get; set; }
    
    [Column("password")]
    [MaxLength(100)]
    public string? Password { get; set; }
    
    [Column("role")]
    [MaxLength(20)]
    public string? Role { get; set; }
    
    [Column("salt")]
    [MaxLength(100)]
    public string? Salt { get; set; }
    
    //public List<Review> Reviews { get; set; }
    //public List<Watchlist> Watchlist { get; set; }
}