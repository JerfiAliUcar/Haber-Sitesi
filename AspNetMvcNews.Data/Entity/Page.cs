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
    public class Page : IAuiditEntity
    {
       

        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string? Content { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
