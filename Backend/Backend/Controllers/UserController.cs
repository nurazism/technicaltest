using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
