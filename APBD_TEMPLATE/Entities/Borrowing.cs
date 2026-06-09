using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_TEMPLATE.Migrations;

[Table("Borrowings")]
public class Borrowing
{
    [Key]
    public int BorrowingId { get; set; }
    
    [Required]
    public DateTime BorrowDate { get; set; }
    
    public DateTime? ReturnDate { get; set; }

    [Required] 
    [MaxLength(50)] 
    public string Status { get; set; } = null!;
    
    [Required]
    public int MemberId { get; set; }

    [ForeignKey(nameof(MemberId))] 
    public Member Member { get; set; } = null!;
    
    [Required]
    public int BookId { get; set; }
    
    [ForeignKey(nameof(BookId))]
    public Book Book { get; set; } = null!;
    
    
}