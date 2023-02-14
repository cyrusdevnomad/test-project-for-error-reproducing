using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using example_bi_directional_consumer_dotnet.core.src.Models;

namespace example_bi_directional_consumer_dotnet.core.src
{
    public class MyApiClient : IMyApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;

        public MyApiClient(HttpClient client, string baseAddress) =>
            (_httpClient, _baseAddress) = (client, baseAddress);

        #region Helper methods

        private void PrepareJSONObject(string urlSufix, object data, out string url, out HttpContent content)
        {
            url = _baseAddress + urlSufix;
            content = null;
            if (data != null)
            {
                var jsonContent = JsonConvert.SerializeObject(data);
                content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            }
        }

        #endregion

        #region HTTP methods

        public async Task<MyActionResult> PostAsync(string urlSufix, object postData, bool returnContent = false)
        {
            try
            {
                PrepareJSONObject(urlSufix, postData, out string url, out var content);
                var response = await _httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                if (returnContent)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return MyActionResult.Success(responseContent);
                }
                else
                    return MyActionResult.Success();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MyActionResult> PostAsync<T>(string urlSufix, object postData, bool shouldIncludeHeaders = false)
        {
            try
            {
                PrepareJSONObject(urlSufix, postData, out string url, out var content);
                var response = await _httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<T>(responseContent);

                return shouldIncludeHeaders ?
                    MyActionResult.Success(new Tuple<T, HttpResponseHeaders>(responseObject, response.Headers)) :
                    MyActionResult.Success(responseObject);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}

