using AspNetMvcNews.Business;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_mvc_news.Controllers
{
    public class CategoryController : Controller
    {

        private readonly INewsService newsService;
        private readonly ICategoryService categoryService;

        public CategoryController(INewsService newsService, ICategoryService categoryService)
        {

            this.newsService = newsService;
            this.categoryService = categoryService;
        }
        public IActionResult Index(int cid)
        {
            var newsCategory = newsService.GetNewsCategories(cid);

            ViewBag.Category = categoryService.GetById(cid);


            return View(newsCategory);
        }

        public IActionResult Search(string q)
        {
            var list = newsService.NewsSearch(q);

            ViewBag.QueryText = q;

            return View(list);
        }
    }
}
