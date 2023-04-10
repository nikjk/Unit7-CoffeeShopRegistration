using Demo_02_MVC_Forms.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_02_MVC_Forms.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // ASP.NET Core's "Model Binders" will capture the properties from the form, and rebuild the model to pass into this action method.

        // When Model Binding is happening, ASP.NET provides us with information on the status of the Model Binding with 'model state.'
        // We can check to make sure that model binding was successful before we try to access the object. EX: if ModelState.IsValid

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
