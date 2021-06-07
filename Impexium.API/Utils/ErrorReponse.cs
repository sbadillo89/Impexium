

namespace Impexium.API.Utils
{
    public class ErrorReponse
    {
        public ErrorReponse()
        {

        }

        public ErrorReponse(string message, System.Net.HttpStatusCode statusCode)
        {
            Message = message;
            Status = statusCode;
        }
        public string Message { get; set; }

        public System.Net.HttpStatusCode Status { get; set; }
    }
}
