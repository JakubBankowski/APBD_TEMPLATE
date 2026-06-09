namespace APBD_TEMPLATE.DTOs;

public class GetMembersResponseDto
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    
    public ICollection<GetMembersBorrowingsResponseDto> borrowings { get; set; }
}