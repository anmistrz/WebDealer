using System;

namespace DealerApi.Application.DTO;

public class RegistrationDTO
{
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string ConfirmPassword { get; set; } = string.Empty;

    // Additional properties can be added as needed

}
