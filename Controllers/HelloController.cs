using Microsoft.AspNetCore.Mvc;

namespace ChillStuff.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute]
        [RouteAttribute("")]
        public IActionResult Index()
        {
            return View("BooBoo");
        }
    }
}