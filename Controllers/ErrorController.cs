using Microsoft.AspNetCore.Mvc;
using mvc;

namespace film_site.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error404")]
        public IActionResult Error404()
        {
            return View("~/Views/Shared/Error404.cshtml");
        }
    }
}
