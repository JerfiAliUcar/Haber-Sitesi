using AspNetMvcNews.Business;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcNews.Web.Mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
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
