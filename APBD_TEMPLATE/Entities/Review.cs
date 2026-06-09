using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_TEMPLATE.Migrations;

[Table("Reviews")]
public class Review
{
    [Required]
    public int MemberId { get; set; }

    [ForeignKey(nameof(MemberId))] 
    public Member Member { get; set; } = null!;
    
    [Required]
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public Book Book { get; set; } = null!;
    
    [Required]
    public int Rating { get; set; }

    [Required] [MaxLength(500)] 
    public string Comment { get; set; } = null!;
    
    [Required]
    public DateTime ReviewDate { get; set; }
}