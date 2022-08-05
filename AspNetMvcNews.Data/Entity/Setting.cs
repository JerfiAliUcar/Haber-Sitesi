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
    public class Setting : BaseEntity
    {
        
        [Required]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(400)")]
        public string? Value { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
