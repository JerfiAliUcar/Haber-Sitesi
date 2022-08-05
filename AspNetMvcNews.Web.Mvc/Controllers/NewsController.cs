using AspNetMvcNews.Business;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_news.Controllers
{
    public class NewsController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly INewsService newsService;

        public NewsController(ICategoryService categoryService, INewsService newsService)
        {
            this.categoryService = categoryService;
            this.newsService = newsService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string q)
        {
            return View();
        }
        public IActionResult Detail(int cid)
        {
            var news = newsService.GetNews(cid);

            return View(news);
        }
    }
}
