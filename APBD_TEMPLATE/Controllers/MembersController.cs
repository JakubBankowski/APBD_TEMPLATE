using APBD_TEMPLATE.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_TEMPLATE.Controllers;

[ApiController]
[Route("api/members")]
public class MembersController : ControllerBase
{
    private readonly IMemberService _service;
    
    public MembersController(IMemberService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetMembers(string? email)
    {
        var result = await _service.GetAllAsync(email);
        return Ok(result);
    }
}