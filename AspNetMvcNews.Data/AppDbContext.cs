using AspNetMvcNews.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcNews.Data
{
    public class AppDbContext : DbContext
    {
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }



        public DbSet<Category> Categories { get; set; } 
        public DbSet<News> News { get; set; } 
        public DbSet<NewsComment> NewsComments { get; set; } 
        public DbSet<NewsImage> NewsImages { get; set; } 
        public DbSet<Page> Pages { get; set; } 
        
        public DbSet<Setting> Settings {get; set; } 
        public DbSet<User> Users {get; set; }

        public DbSet<CategoryNews> CategoryNews { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<News>()
          .HasMany(p => p.Categories)
          .WithMany(p => p.NewsCategory)
          .UsingEntity<CategoryNews>(
              j => j
                  .HasOne(pt => pt.category).WithMany()
                  .HasForeignKey(pt => pt.CategoryId),
              j => j
                  .HasOne(pt => pt.news).WithMany()
                  .HasForeignKey(pt => pt.NewsId),
              j =>
              {
                  j.HasKey(t => new { t.NewsId, t.CategoryId });
              });
         

        }
    }
}
