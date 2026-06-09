using APBD_TEMPLATE.DTOs;
using APBD_TEMPLATE.Exceptions;
using APBD_TEMPLATE.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_TEMPLATE.Controllers;

[ApiController]
[Route("api/borrowings")]
public class BorrowingsController : ControllerBase
{
    private readonly IBorrowingService _service;
    
    public BorrowingsController(IBorrowingService service)
    {
        _service = service;
    }

    [HttpPost("{id}/result")]
    public async Task<IActionResult> ReturnBorrowing(int id, [FromBody] ReturnBorrowingRequestDto dto)
    {
        try
        {
            await _service.ReturnBorrowingAsync(id, dto);
            return NoContent();
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (BadRequestException e)
        {
            return BadRequest(e.Message);
        }
    }
}