using Microsoft.AspNetCore.Mvc;
using DealerApi.Application.Interface;

namespace DealerApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private readonly ICarServices _carServices;
        public CarController(ICarServices carServices)
        {
            _carServices = carServices ?? throw new ArgumentNullException(nameof(carServices));
        }



        [HttpGet]
        [Route("GetCarOptions")]
        public async Task<IActionResult> GetCarOptions()
        {
            try
            {
                var carOptions = await _carServices.GetCarOptions();
                return Ok(carOptions);
            }
            catch (Exception ex)
            {
                // Log the exception as needed
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}

