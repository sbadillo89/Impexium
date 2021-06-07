namespace Impexium.Proxy
{
    public class GlobalResponse
    {
        public string RequestData { get; set; }

        public string ResponseData { get; set; }

        public System.Net.HttpStatusCode Status { get; set; }

        public string Message { get; set; }
    }
}
