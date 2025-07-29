using Microsoft.AspNetCore.Mvc;

namespace HamyarApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
