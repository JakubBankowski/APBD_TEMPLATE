namespace APBD_TEMPLATE.DTOs;

public class GetMembersBorrowingsResponseDto
{
    public int borrowingId { get; set; }
    public GetMembersBookResponseDto book { get; set; }
    public DateTime borrowDate { get; set; }
    public DateTime? returnDate { get; set; }
    public string status { get; set; }
}