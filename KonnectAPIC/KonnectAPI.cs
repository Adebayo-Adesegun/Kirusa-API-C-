using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KonnectAPIC
{
   public class KonnectAPI
    {
        private readonly HttpClient _httpClient;
        string baseurl;
        /// <summary>
        /// Initialize 
        /// </summary>
        /// <param name="authKey"></param>
        /// <param name="authId"></param>
        public KonnectAPI(string authKey, string accountId)
        {
            baseurl = $"https://konnect.kirusa.com/api/v1/Accounts/{accountId}/";
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseurl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization" , authKey);
          
        }

        /// <summary>
        /// Send SMS service.
        /// </summary>
        /// <param name="request">The request object</param>
        /// <returns></returns>
        public async Task<bool> SendSMS(RequestSMS request)
        {
            try
            {
                var uri = baseurl + "Messages";
                var content = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore});
                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await _httpClient.PostAsync(uri, byteContent);
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;
        }

        /// <summary>
        /// Send Voice Service
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<bool> SendVoice(RequestVoice request)
        {
            try
            {
                var uri = baseurl + "Calls";
                var content = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await _httpClient.PostAsync(uri, byteContent);
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return false;

        }

    }
}
