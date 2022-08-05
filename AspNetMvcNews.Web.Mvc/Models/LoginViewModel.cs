using System.ComponentModel.DataAnnotations;

namespace AspNetMvcNews.Web.Mvc.Models
{
    public class LoginViewModel
    {
        [Required]
        public string? EmailAdress { get; set; }

        [Required]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
