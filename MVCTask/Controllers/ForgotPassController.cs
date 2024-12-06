using Microsoft.AspNetCore.Mvc;

namespace MVCTask.Controllers
{
    public class ForgotPassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
