using APBD_TEMPLATE.DTOs;

namespace APBD_TEMPLATE.Services;

public interface IBorrowingService
{
    Task ReturnBorrowingAsync(int id, ReturnBorrowingRequestDto dto);
}