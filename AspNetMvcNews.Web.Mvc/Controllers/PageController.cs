using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_news.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
