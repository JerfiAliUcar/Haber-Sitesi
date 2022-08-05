using AspNetMvcNews.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcNews.Data.Entity
{
    public class News : IAuiditEntity
    {
        public int? UserId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Title { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string? Content { get; set; }

        public int ViewCount { get; set; }

        [ForeignKey("UserId")]
        public virtual User? User { get; set; }

        public virtual List<NewsImage> NewsImages { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<NewsComment> Comments { get; set; }
    }
}