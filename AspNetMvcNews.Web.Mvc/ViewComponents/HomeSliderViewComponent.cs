using AspNetMvcNews.Business;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcNews.Web.Mvc.ViewComponents
{
    public class HomeSliderViewComponent : ViewComponent
    {
        private readonly INewsService newsService;
        private readonly ICategoryService categoryService;

        public HomeSliderViewComponent(INewsService newsService, ICategoryService categoryService)
        {
            this.newsService = newsService;
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            var news= newsService.GetAllNews();
            return View(news);
        }
    }
}
