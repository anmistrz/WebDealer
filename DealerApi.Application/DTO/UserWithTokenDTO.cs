using System;

namespace DealerApi.Application.DTO;

public class UserWithTokenDTO
{
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
}
