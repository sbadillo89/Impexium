using System;

namespace Impexium.API.Services
{
    public class AuthResponse
    {
        public AuthResponse()
        { 
            Message = "Access granted";
        }
        public Guid UserId { get; set; }

        public string UserName { get; set; } 

        public string Token { get; set; }

        public string Message { get; set; }

        public DateTime ExpireDate { get; set; } 
        public System.Net.HttpStatusCode Status { get; set; }

    }
}
