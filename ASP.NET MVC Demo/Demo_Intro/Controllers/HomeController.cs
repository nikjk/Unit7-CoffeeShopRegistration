using Demo_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo_Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MockDatabase _db;
        public HomeController(ILogger<HomeController> logger, MockDatabase mockDb)
        {
            _logger = logger;
            _db = mockDb;
        }

        public IActionResult Index()
        {
            return View(_db.GetUserProfiles());
        }

        // Let's add an About Me page
        public IActionResult AboutMe()
        {
            // For demonstration purposes, we are going to create a new UserProfile instance here in the controller. (Normally this data might come from a database)
            // And then... we will pass it to the AboutMe view

            UserProfile profile = new UserProfile();
            profile.FirstName = "Antonio";
            profile.LastName = "Manzari";
            profile.Bio = "I am a human and I enjoy eating mangos.";
            profile.ProfileImage = "/images/condesa.jpg";

            return View(profile); // This View() method will be called and it will search the Views folder for a "view" (a razor file / .cshtml file) named AboutMe.cshtml
        }

        // Now let's add a Careers page: example.com/home/careers
        public IActionResult Careers()
        {
            // We are creating a list of strings and we want to send it over to the Careers View
            List<string> openPositions = new List<string>()
            {
                "Juice Leader",
                "Cloud Fantasy Mentor",
                "Apple Straw Conductor"
            };

            // We can send a list of strings to the view by simply passing it in as an argument

            return View(openPositions); // MVC will search for a Careers.cshtml file in Views/Home/Careers.cshtml
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