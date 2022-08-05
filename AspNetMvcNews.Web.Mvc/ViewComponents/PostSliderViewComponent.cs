using AspNetMvcNews.Business;
using AspNetMvcNews.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcNews.Web.Mvc.ViewComponents
{
    public class PostSliderViewComponent : ViewComponent
    {
        private readonly INewsService newsService;
         private readonly ICategoryService categoryService;

        public PostSliderViewComponent(INewsService newsService, ICategoryService categoryService)
        {
            this.newsService = newsService;
            this.categoryService = categoryService;
        }
        public IViewComponentResult Invoke(int cid, string PageType)
        {

            var news= new List<News>();
            if (PageType == "Home")
            {
                news = newsService.GetAllNews();
            }
            else if (PageType == null)
            {
                news = newsService.GetNewsCategories(cid);
            }
            return View(news);
        }
    }
}
