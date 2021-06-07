using System.ComponentModel.DataAnnotations;

namespace Impexium.API.Services
{
    public class AuthRequest
    {

        [Required] 
        public string User { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
