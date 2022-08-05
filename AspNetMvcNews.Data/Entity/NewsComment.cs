using AspNetMvcNews.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcNews.Data.Entity
{
    public class NewsComment : IAuiditEntity
    {
        [Required]
        public int PostId { get; set; }

        public int? UserId { get; set; }


        [DataType(DataType.Text)]

        public string? Comment { get; set; }

        [Required]
        public bool IsActive { get; set; }

        // Navigation
        [ForeignKey("PostId")]
        public virtual News news { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
