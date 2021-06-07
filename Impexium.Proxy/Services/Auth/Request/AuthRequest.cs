using System.ComponentModel.DataAnnotations;

namespace Impexium.Proxy.Services
{
    public class AuthRequest
    {
        [Required (ErrorMessage ="Please enter a Username")]
        public string User { get; set; }

        [Required(ErrorMessage = "Please enter a Password")]
        public string Password { get; set; }
    }
}
