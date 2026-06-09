using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_TEMPLATE.Migrations;

[Table("Members")]
public class Member
{
    [Key]
    public int MemberId { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = null!;
    
    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = null!;
    
    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = null!;
    
    [Required]
    [MaxLength(9)]
    public string Phone { get; set; } = null!;
    
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();

}