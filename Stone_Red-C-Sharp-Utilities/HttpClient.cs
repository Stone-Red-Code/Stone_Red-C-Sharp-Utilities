using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Stone_Red_Utilities.Http
{
    public static class HttpClientExtentions
    {
        public static async Task<T> GetJsonObjectAsync<T>(this HttpClient httpClient, string requestUri)
        {
            return JsonSerializer.Deserialize<T>(await httpClient.GetStringAsync(requestUri));
        }

        public static async Task<T> GetJsonObjectAsync<T>(this HttpClient httpClient, Uri requestUri)
        {
            return JsonSerializer.Deserialize<T>(await httpClient.GetStringAsync(requestUri));
        }
    }
}