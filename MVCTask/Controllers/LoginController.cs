using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
