using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class SpeakerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
