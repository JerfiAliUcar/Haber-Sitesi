using AspNetMvcNews.Data;
using AspNetMvcNews.Data.Entity;

namespace AspNetMvcNews.Business
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetById(int cid);
    }

    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _db;

        public CategoryService(AppDbContext db)
        {
            _db = db;
        }

        public List<Category> GetAllCategories()
        {
            var list = _db.Categories.ToList();


            return list;
        }

        public Category GetById(int cid)
        {
            return _db.Categories.FirstOrDefault(e => e.Id == cid);
        }
    }
}
