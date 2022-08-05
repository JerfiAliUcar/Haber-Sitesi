using System.ComponentModel.DataAnnotations;

namespace AspNetMvcNews.Web.Mvc.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        public string? EmailAdress { get; set; }

        [Required]
        public string? Password { get; set; }
        
        [Required]
        public string? Password2 { get; set; }
    }
}
