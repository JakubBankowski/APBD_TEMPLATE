using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_TEMPLATE.Migrations;

[Table("Books")]
public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required] [MaxLength(200)] public string Title { get; set; } = null!;

    [Required] [MaxLength(13)] public string ISBN { get; set; } = null!;
    
    [Required]
    public int PublishedYear { get; set; }
    
    [Required]
    public int AuthorsId { get; set; }

    [ForeignKey(nameof(AuthorsId))] 
    public Author Author { get; set; } = null!;
    
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

}