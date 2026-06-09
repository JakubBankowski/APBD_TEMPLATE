using APBD_TEMPLATE.Data;
using APBD_TEMPLATE.DTOs;
using APBD_TEMPLATE.Migrations;
using Microsoft.EntityFrameworkCore;

namespace APBD_TEMPLATE.Services;

public class MemberService : IMemberService
{
    private readonly ApplicationDbContext _context;

    public MemberService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<GetMembersResponseDto>> GetAllAsync(string? email = null)
    {
        var members = await _context.Members
            .Where(m => email == null || m.Email == email)
            .Include(m => m.Borrowings)
            .ThenInclude(b => b.Book)
            .ThenInclude(b => b.Author)
            .ToListAsync();

        var result = members.Select(m => new GetMembersResponseDto
        {
            firstName = m.FirstName,
            lastName = m.LastName,
            email = m.Email,
            phone = m.Phone,
            borrowings = m.Borrowings.Select( b => new GetMembersBorrowingsResponseDto
            {
                borrowingId = b.BorrowingId,
                book = new GetMembersBookResponseDto
                {
                    bookId = b.BookId,
                    title = b.Book.Title,
                    isbn =  b.Book.ISBN,
                    publishedYear = b.Book.PublishedYear,
                    author = new GetMembersAuthorResponseDto
                    {
                        firstName = b.Book.Author.FirstName,
                        lastName = b.Book.Author.LastName,
                        country = b.Book.Author.Country
                    }
                },
                borrowDate = b.BorrowDate,
                returnDate = b.ReturnDate,
                status = b.Status,
            }).ToList()
        }).ToList();

        return result;
    }
}