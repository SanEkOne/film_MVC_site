using Microsoft.AspNetCore.Mvc;
using mvc;

namespace film.Controllers
{
    public class TrailerController : Controller
    {
        public IActionResult Index(string link)
        {
            ViewData["trailerLink"] = link;
            return View();
        }

        public IActionResult RedirectMethod()
        {
            return Redirect("/filmTrailer/Index");
        }
    }
}
