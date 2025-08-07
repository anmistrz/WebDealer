using System;

namespace DealerApi.Application.DTO;

public class TestDriveGuestDTO
{
    public int CarId { get; set; }
    public int DealerId { get; set; }
    public int DealerCarUnitId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime AppointmentDate { get; set; }
    public string Note { get; set; } = string.Empty;
}
