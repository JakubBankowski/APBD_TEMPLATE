using APBD_TEMPLATE.Data;
using APBD_TEMPLATE.DTOs;
using APBD_TEMPLATE.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace APBD_TEMPLATE.Services;

public class BorrowingService : IBorrowingService
{
    private readonly ApplicationDbContext _context;

    public BorrowingService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task ReturnBorrowingAsync(int id, ReturnBorrowingRequestDto dto)
    {
        var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var borrowing = await _context.Borrowings.FindAsync(id);
            if (borrowing == null) throw new NotFoundException("No borrowing found.");

            if (borrowing.Status == "Returned") throw new BadRequestException("Borrowing is already returned.");
            if (dto.returnDate < borrowing.BorrowDate)
                throw new BadRequestException("Provided return date is too early.");

            borrowing.ReturnDate = dto.returnDate;
            borrowing.Status = "Returned";

            await _context.SaveChangesAsync();

            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}