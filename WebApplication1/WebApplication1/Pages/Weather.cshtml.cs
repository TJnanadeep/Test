using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System;
using WeatherApplication.Models;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication1.Pages
{
    public class WeatherModel : PageModel
    {
        public List<WeatherDetails> WeatherData { get; set; } = new();

        public string City { get; set; }

        public string SelectedCities { get; set; }

        public List<SelectListItem> Cities { get; set; } = new()
        {
        new SelectListItem { Value = "Hyderabad", Text = "Hyderabad" },
        new SelectListItem { Value = "Bangalore", Text = "Bangalore" },
        new SelectListItem { Value = "Chennai", Text = "Chennai" },
        new SelectListItem { Value = "Mumbai", Text = "Mumbai" }
        };

        public string SubmittedCities { get; set; } = "";

        public List<string> Response { get; set; } = new();

        public string ErrorMessage { get; set; }

        private readonly ILogger<WeatherModel> _logger;

        public WeatherModel(ILogger<WeatherModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostWeather(string SelectedCities)
        {
            //if (string.IsNullOrEmpty(City))
            //{
            //    //ModelState.AddModelError("InputString", "The input string cannot be empty.");
            //    ErrorMessage = "The input string cannot be empty.";
            //    return Page();
            //}
            for (int i=0;i< SelectedCities.Split(',').Length; i++)
            {
                if (Regex.IsMatch(SelectedCities.Split(',')[i], @"^[a-zA-Z]+$"))
                {
                    var apiUrl = "https://weather.visualcrossing.com//VisualCrossingWebServices//rest//services//timeline//" + SelectedCities.Split(',')[i] + "?unitGroup=metric&key=8YXDVQADHRXFXSUANFZN4M5A8&contentType=json";

                    // POST to the API
                    Response.Add(await CallRestMethodAsync(apiUrl));   
                }
                else

                {
                    ErrorMessage = "Input string is not a valid city or state.";
                    return Page();
                }
            }
            foreach (string R in Response)
            {
                if (R != "False")
                {
                    WeatherData.Add(display(R));
                }
                else
                {
                    ErrorMessage = "Invalid Input. Please provide a valid City or state";
                    return Page();
                }
            }
            return Page();
        }

        public static async Task<string> CallRestMethodAsync(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return "False";
            }
        }

        public WeatherDetails display(string details)
        {
            WeatherDetails details2 = new WeatherDetails();

            try
            {
                if (details != "False")
                {
                   
                    details2.Address = JsonConvert.DeserializeObject<WeatherDetails>(details).Address;
                    details2.days = JsonConvert.DeserializeObject<WeatherDetails>(details).days;
                    details2.weathericon = "Icons/"+JsonConvert.DeserializeObject<WeatherDetails>(details).days[0].Icon + ".png";
                }
                else { Console.WriteLine("Mentioned City or State information is not available"); }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return details2;
        }
    }
}