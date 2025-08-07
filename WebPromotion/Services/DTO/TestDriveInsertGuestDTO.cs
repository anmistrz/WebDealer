using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebPromotion.Services.DTO
{
    public class TestDriveInsertGuestDTO
    {
        public int CarId { get; set; }
        public int DealerId { get; set; }
        public int DealerCarUnitId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Note { get; set; }

    }
}