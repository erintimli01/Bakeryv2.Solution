
using Microsoft.AspNetCore.Mvc;

namespace Bakeryv2.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}