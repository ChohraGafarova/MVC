using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
