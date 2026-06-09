using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_TEMPLATE.Migrations;

[Table("Authors")]
public class Author
{
    [Key]
    public int AuthorId { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
 
    [Required]
    [MaxLength(50)]
    public string Country { get; set; }
    
    
    [Required]
    public int BirthYear { get; set; }
    
    public ICollection<Book> Books { get; set; } = new List<Book>();
    
}