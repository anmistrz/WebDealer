using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DealerApi.Application.DTO
{
    public class ConsultHistoryGuestDTO
    {
        public int CustomerId { get; set; }

        [Required]
        public int DealerCarUnitId { get; set; }

        [Required]
        public int DealerId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [Phone]
        [StringLength(15)]
        public string PhoneNumber { get; set; } = string.Empty;

        public int? SalesPersonId { get; set; }

        public decimal? Budget { get; set; }

        [Required]
        public DateTime ConsultDate { get; set; }

        [StringLength(500)]
        public string? Note { get; set; }

        // Additional properties can be added as needed
    }
}