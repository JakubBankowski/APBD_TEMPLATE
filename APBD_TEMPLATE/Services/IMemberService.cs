using APBD_TEMPLATE.DTOs;
using APBD_TEMPLATE.Migrations;

namespace APBD_TEMPLATE.Services;

public interface IMemberService
{
    Task<IEnumerable<GetMembersResponseDto>> GetAllAsync(string? email = null);
}