using System.Net.Http;
using System.Threading.Tasks;

namespace WpfApp1.Services
{
    public class RestBase
    {
        private readonly HttpClient _httpContext;
        private readonly string BaseUrl = "https://localhost:44345";
        public RestBase()
        {
            _httpContext = new HttpClient();          
        }

        public async Task<HttpResponseMessage> HttpGetAsync(string endpoint)
        {
            var response = await _httpContext.GetAsync($"{BaseUrl}/{endpoint}");

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //do something unauthorized request
            }
            return response;
        }
        public async Task<HttpResponseMessage> HttpDeleteAsync(string endpoint)
        {
            var response = await _httpContext.DeleteAsync($"{BaseUrl}/{endpoint}");

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //do something unauthorized request
            }
            return response;
        }
        public async Task<HttpResponseMessage> HttpPostAsync(string endpoint, HttpContent content)
        {
            var response = await _httpContext.PostAsync($"{BaseUrl}/{endpoint}", content);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //do something unauthorized request
            }
            return response;
        }
        public async Task<HttpResponseMessage> HttpPutAsync(string endpoint, HttpContent content)
        {
            var response = await _httpContext.PutAsync($"{BaseUrl}/{endpoint}", content);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                //do something unauthorized request
            }
            return response;
        }
        public void Dispose()
        {
            _httpContext.Dispose();
        }
    }
}
