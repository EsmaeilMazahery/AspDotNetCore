using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.DataLayer.Models;

public class Foo
{
    [Key] public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = "";

    [Required]
    [RegularExpression(Constants.MobileRegex)]
    [Column(TypeName = "char")]
    [StringLength(maximumLength: 10, MinimumLength = 10)]
    public string Mobile { get; set; } = "";

    [EmailAddress]
    [MaxLength(320)]
    public string? Email { get; set; }

    [Phone]
    [Column(TypeName = "char")]
    [StringLength(maximumLength: 10, MinimumLength = 10)]
    public string? PhoneNumber { get; set; }

    [MaxLength(4000)]
    public string? Description { get; set; }
            
    public DateTime RegisterDate { get; set; } = DateTime.Now;
}