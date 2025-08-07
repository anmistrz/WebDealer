using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebPromotion.BL.CarBL;
using WebPromotion.BL.ConsultHistoryBL;
using WebPromotion.BL.DealerBL;
using WebPromotion.Models;
using WebPromotion.ViewModels.ConsultHistoryView;
using WebPromotion.ViewModels.Modal;
using WebPromotion.Models;
// using WebPromotion.BL.DealerCar;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebPromotion.Services.DealerCar;
namespace WebPromotion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarBL _carBL;
        private readonly IDealerBL _dealerBL;
        private readonly IConsultHistoryBL _consultationBL;

        private readonly IDealerCarServices _dealerCarService;


        public HomeController(ILogger<HomeController> logger, ICarBL carBL, IDealerBL dealerBL, IConsultHistoryBL consultHistoryBL, IDealerCarServices dealerCarServices)
        {
            _carBL = carBL;
            _logger = logger;
            _dealerBL = dealerBL;
            _consultationBL = consultHistoryBL;
            _dealerCarService = dealerCarServices ?? throw new ArgumentNullException(nameof(dealerCarServices));
        }

        public IActionResult Index()
        {
            try
            {

                var DealerCarOptions = _dealerCarService.GetOptionsDealerCarUnitByStatusAsync("TestDrive").Result;

                ViewBag.DealerCarOptions = DealerCarOptions;
                Console.WriteLine($"DealerCarOptions: {JsonSerializer.Serialize(DealerCarOptions)}");
                
                ViewBag.DealerOptions = DealerCarOptions?
                    .SelectMany(option => option.Dealers)
                    .Select(x => new SelectListItem
                    {
                        Value = x.DealerID.ToString(),
                        Text = x.DealerName
                    }).ToList() ?? new List<SelectListItem>();

                ViewBag.CarOptions = DealerCarOptions?
                    .SelectMany(option => option.Cars)
                    .Select(x => new SelectListItem
                    {
                        Value = x.CarId.ToString(),
                        Text = x.CarName
                    }).ToList() ?? new List<SelectListItem>();

                // Handle modal dari TempData setelah redirect
                if (TempData["SuccessModal"] != null)
                {
                    var successModalJson = TempData["SuccessModal"]?.ToString();
                    if (!string.IsNullOrEmpty(successModalJson))
                    {
                        ViewBag.SuccessModal = JsonSerializer.Deserialize<ModalViewModels>(successModalJson);
                    }
                }
                
                if (TempData["ErrorModal"] != null)
                {
                    var errorModalJson = TempData["ErrorModal"]?.ToString();
                    if (!string.IsNullOrEmpty(errorModalJson))
                    {
                        ViewBag.ErrorModal = JsonSerializer.Deserialize<ModalViewModels>(errorModalJson);
                    }
                }
                
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving car options");
                ViewBag.ErrorMessage = "An error occurred while loading car options.";
            }

            return View();
        }

        [HttpPost]
        public IActionResult AddConsultation(ConsultHistoryInsertGuestViewModels model)
        {
            Console.WriteLine($"Received model: {JsonSerializer.Serialize(model)}");
            
            // Additional validation for DealerId
            if (model.DealerId == 0)
            {
                ModelState.AddModelError("DealerId", "Please select a dealer");
            }
            
            if (ModelState.IsValid)
            {
                try
                {
                    // Call your BL layer to add the consultation
                    _consultationBL.InsertConsultHistoryGuest(model);

                    // Set success modal untuk ditampilkan di Index
                    TempData["SuccessModal"] = JsonSerializer.Serialize(new ModalViewModels
                    {
                        Title = "Success",
                        Message = "Consultation has been successfully added!",
                        ButtonText = "OK",
                        IsVisible = true,
                        Type = "success"
                    });

                    // Redirect ke Index setelah insert berhasil
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error adding consultation");

                    // Set error modal untuk ditampilkan di Index
                    TempData["ErrorModal"] = JsonSerializer.Serialize(new ModalViewModels
                    {
                        Title = "Error",
                        Message = "Failed to add consultation. Please try again.",
                        ButtonText = "OK",
                        IsVisible = true,
                        Type = "failed"
                    });

                    return RedirectToAction("Index");
                }
            }
            else
            {
                // Set validation error modal untuk ditampilkan di Index
                TempData["ErrorModal"] = JsonSerializer.Serialize(new ModalViewModels
                {
                    Title = "Validation Error",
                    Message = "Please fill in all required fields correctly.",
                    ButtonText = "OK",
                    IsVisible = true,
                    Type = "failed"
                });

                return RedirectToAction("Index");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
