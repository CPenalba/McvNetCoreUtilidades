using Microsoft.AspNetCore.Mvc;

namespace McvNetCoreUtilidades.Controllers
{
    public class CachingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MemoriaDistribuida()
        {
            string fecha = DateTime.Now.ToLongDateString() + " -- " + DateTime.Now.ToLongTimeString();
            ViewData["FECHA"] = fecha;
            return View();
        }
    }
}
