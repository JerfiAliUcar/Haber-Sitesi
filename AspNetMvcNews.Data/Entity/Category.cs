using AspNetMvcNews.Data.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvcNews.Data.Entity
{
    public class Category : BaseEntity
    {

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        public virtual ICollection<News> NewsCategory { get; set; }
    }
}
