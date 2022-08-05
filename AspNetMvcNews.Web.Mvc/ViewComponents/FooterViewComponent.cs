using AspNetMvcNews.Business;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcNews.Web.Mvc.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public FooterViewComponent(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.Categories = categoryService.GetAllCategories();
            return View();
        }
    }
}
