using Impexium.Proxy.Services;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace Impexium.Proxy.Repository
{
    public class Repository<T>
        : IRepository<T>
        where T : class

    {
        readonly string baseUrl = ConfigurationManager.AppSettings["ApiUrl"];

        readonly HttpClient _httpClient;
        private GlobalResponse globalResponse;

        public Repository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Repository()
        { 
           _httpClient = new HttpClient() { BaseAddress = new System.Uri("https://www.sergiobadillo.somee.com/") };
        }

        public async Task<GlobalResponse> GetAllAsync(string requestUri)
        {
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await _httpClient.SendAsync(requestMsg);

            globalResponse = new GlobalResponse
            {
                ResponseData = response.Content.ReadAsStringAsync().Result,
                Status = response.StatusCode,
                Message = response.IsSuccessStatusCode ? "Processed Completed" : "Error getting information."
            };

            return globalResponse;
        }

        public async Task<GlobalResponse> GetByIdAsync(string requestUri)
        {
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await _httpClient.SendAsync(requestMsg);

            globalResponse = new GlobalResponse
            {
                ResponseData = response.Content.ReadAsStringAsync().Result,
                Status = response.StatusCode,
                Message = response.IsSuccessStatusCode ? "Processed Completed" : "Error getting information."
            };

            return globalResponse;
        }

        public async Task<GlobalResponse> Login(string requestUri, AuthRequest auth)
        {

            string serializedRequest = JsonConvert.SerializeObject(auth);
            var response = await _httpClient.PostAsJsonAsync(requestUri, auth, System.Threading.CancellationToken.None);

            globalResponse = new GlobalResponse
            {
                RequestData = serializedRequest,
                ResponseData = response.Content.ReadAsStringAsync().Result,
                Status = response.StatusCode,
                Message = response.IsSuccessStatusCode ? "Processed Completed" : "Error Logging."
            };

            return globalResponse;

        }

        public async Task<GlobalResponse> PostAsync(string requestUri, T requestData, string token)
        {
            string serializedRequest = JsonConvert.SerializeObject(requestData);
            var requestMsg = new HttpRequestMessage(HttpMethod.Post, requestUri);
            requestMsg.Headers.Add("Authorization", "Bearer " + token);
            requestMsg.Content = new StringContent(serializedRequest);
            requestMsg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.SendAsync(requestMsg);

            globalResponse = new GlobalResponse
            {
                RequestData = serializedRequest,
                ResponseData = response.Content.ReadAsStringAsync().Result,
                Status = response.StatusCode,
                Message = response.IsSuccessStatusCode ? "Processed Completed" : "Error inserting data"
            };

            return globalResponse;

        }

        public async Task<GlobalResponse> PutAsync(string requestUri, T requestData, string token)
        {

            string serializedRequest = JsonConvert.SerializeObject(requestData);

            var requestMsg = new HttpRequestMessage(HttpMethod.Put, requestUri);
            requestMsg.Headers.Add("Authorization", "Bearer " + token);
            requestMsg.Content = new StringContent(serializedRequest);
            requestMsg.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var response = await _httpClient.SendAsync(requestMsg);


            globalResponse = new GlobalResponse
            {
                RequestData = serializedRequest,
                ResponseData = response.Content.ReadAsStringAsync().Result,
                Status = response.StatusCode,
                Message = response.IsSuccessStatusCode ? "Processed Completed" : "Error inserting data"
            };

            return globalResponse;
        }

    }
}
