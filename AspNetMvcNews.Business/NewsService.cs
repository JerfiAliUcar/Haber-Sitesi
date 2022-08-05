using AspNetMvcNews.Data;
using AspNetMvcNews.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetMvcNews.Business
{
    public interface INewsService
    {
        List<News> GetAllNews();

        List<News> GetNewsCategories(int categoryId);

        List<News> NewsSearch(string q);

        News GetNews(int id);
    }

    public class NewsService : INewsService
    {
        private readonly AppDbContext _db;

        public NewsService(AppDbContext db)
        {
            _db = db;
        }

        public List<News> GetAllNews()
        {
            var list = _db.News
                .Include(e => e.Comments).ThenInclude(e => e.User)
                .Include(e => e.Categories)
                .Include(e => e.NewsImages)
                .Include(e => e.User)
                .ToList();

            return list;
        }

        public News GetNews(int id)
        {
            var item = _db.News
                .Include(e => e.User)
                .Include(e => e.Comments).ThenInclude(e => e.User)
                .Include(e => e.Categories)
                .Include(e => e.NewsImages)
                .FirstOrDefault(e => e.Id == id);

            return item;
        }

        public List<News> GetNewsCategories(int categoryId)
        {
            var list = _db.News
                .Include(e => e.NewsImages)
                .Include(e => e.Comments).ThenInclude(e => e.User)
                .Include(e => e.User)
                .Include(e => e.Categories)
                .Where(e => e.Categories.Any(a => a.Id == categoryId))
                .ToList();

            return list;
        }

        public List<News> NewsSearch(string q)
        {
            var list = new List<News>();

            if (!string.IsNullOrEmpty(q))
            {
                var kelime = q.Split(" ").ToList();
                foreach (var item in kelime)
                {
                    list.AddRange(
                        _db.News
                            .Include(e => e.NewsImages)
                            .Include(e => e.Comments).ThenInclude(e => e.User)
                            .Include(e => e.User)
                            .Include(e => e.Categories)
                            .Where(e => e.Content.ToLower().Contains(item.ToLower()))
                            .ToList());
                }
                var listTam = list.Distinct().ToList();
                return listTam;
            }

            return list;
        }
    }
}