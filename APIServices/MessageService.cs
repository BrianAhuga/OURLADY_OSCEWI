using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace APIServices
{
    public class MessageService
    {
        private readonly HttpClient httpClient;
        public MessageService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ServiceResponse> PostEmail(Mail item)
        {
            var response = await httpClient.PostAsJsonAsync("Messaging/mail", item);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            ServiceResponse apiResponse = JsonSerializer.Deserialize<ServiceResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return apiResponse;
        }
    }
}
