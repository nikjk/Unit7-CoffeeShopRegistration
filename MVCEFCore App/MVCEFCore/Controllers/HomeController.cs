using Microsoft.AspNetCore.Mvc;
using MVCEFCore.Models;
using System.Diagnostics;

namespace MVCEFCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppUserRepository _AppUserRepo;

        public HomeController(AppUserRepository appUserRepository)
        {
            _AppUserRepo = appUserRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}