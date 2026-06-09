namespace APBD_TEMPLATE.DTOs;

public class GetMembersBookResponseDto
{
    public int bookId { get; set; }
    public string title { get; set; }
    public string isbn { get; set; }
    public int publishedYear { get; set; }
    public GetMembersAuthorResponseDto author { get; set; }
}