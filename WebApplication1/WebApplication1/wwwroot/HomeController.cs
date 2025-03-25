using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WeatherApplications.wwwroot
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            string data = await _apiService.GetDataAsync("posts"); // Replace with the actual endpoint
            ViewBag.Data = data;
            return View();
        }
    }
}
