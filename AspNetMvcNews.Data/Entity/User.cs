using AspNetMvcNews.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetMvcNews.Data.Entity
{
    public class User : IAuiditEntity
    {
        //[Required]
        //[Key]
        //public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? City { get; set; }


        public virtual List<Setting> SettingUser { get; set; }

        public virtual List<News> NewsUser { get; set; }
         public virtual List<NewsComment> NewsComment { get; set; }

    }
}
