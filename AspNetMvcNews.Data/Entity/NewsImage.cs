using AspNetMvcNews.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcNews.Data.Entity
{
    public class NewsImage : BaseEntity
    {
        [Required]
        public int NewsId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string ImagePath { get; set; }

        [ForeignKey("NewsId")]
        public virtual News News { get; set; }
    }
}
