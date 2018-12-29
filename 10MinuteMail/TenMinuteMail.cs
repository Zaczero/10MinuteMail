using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace _10MinuteMail
{
    public class TenMinuteMail
    {
        private const string baseUrl = "https://10minutemail.com/10MinuteMail/resources/";

        private readonly HttpClient httpClient;

        public TenMinuteMail()
        {
            httpClient = new HttpClient();
        }

        private void SetCookies(HttpResponseMessage responseMessage)
        {
            if (responseMessage.Headers.TryGetValues("set-cookie", out var cookies))
            {
                foreach (var cookie in cookies)
                {
                    httpClient.DefaultRequestHeaders.Add("Cookie", cookie);
                }
            }
        }

        public async Task<string> GetEmail()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "session/address");
            var response = await httpClient.SendAsync(request);

            SetCookies(response);

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<int> GetSecondsLeft()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "session/secondsLeft");
            var response = await httpClient.SendAsync(request);

            SetCookies(response);
            
            return int.Parse(await response.Content.ReadAsStringAsync());
        }

        public async Task ResetTime()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "session/reset");
            var response = await httpClient.SendAsync(request);

            SetCookies(response);
        }

        public async Task<int> GetMessageCount()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "messages/messageCount");
            var response = await httpClient.SendAsync(request);

            SetCookies(response);

            return int.Parse(await response.Content.ReadAsStringAsync());
        }

        public async Task<Mail[]> GetMessages()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "messages/messagesAfter/0");
            var response = await httpClient.SendAsync(request);

            SetCookies(response);

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Mail[]>(json);
        }
    }
}
