using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerApi.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DealerApi.API2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DealerCarController : ControllerBase
    {
        private readonly IDealerCarServices _dealerCarService;

        public DealerCarController(IDealerCarServices dealerCarServices)
        {
            _dealerCarService = dealerCarServices;
        }

        [HttpGet("options-by-status/{status}")]
        public async Task<IActionResult> GetOptionsDealerCarUnitByStatus(string status)
        {
            try
            {
                var options = await _dealerCarService.GetOptionsDealerCarUnitByStatus(status);
                return Ok(options);
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
    }
}