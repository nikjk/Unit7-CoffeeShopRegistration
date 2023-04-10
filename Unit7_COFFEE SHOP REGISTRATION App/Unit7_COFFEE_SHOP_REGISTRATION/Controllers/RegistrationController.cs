using Microsoft.AspNetCore.Mvc;
using Unit7_COFFEE_SHOP_REGISTRATION.Models;

namespace Unit7_COFFEE_SHOP_REGISTRATION.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("ThankYou", userProfile);
        }

        //App/ThankYou
        public IActionResult ThankYou(UserProfile userProfile)
        {
            return View(userProfile);
        }
    }
}
