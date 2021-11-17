using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Stone_Red_Utilities.Http
{
    /// <summary>
    /// Extensions for <see cref="HttpClient"/>
    /// </summary>
    public static class HttpClientExtentions
    {
        /// <summary>
        /// Reads the JSON returned from the website and converts it into an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpClient">The http client used for the request</param>
        /// <param name="requestUri">The Uri the request is sent to/></param>
        /// <returns></returns>
        public static async Task<T> GetJsonObjectAsync<T>(this HttpClient httpClient, string requestUri)
        {
            return JsonSerializer.Deserialize<T>(await httpClient.GetStringAsync(requestUri));
        }

        /// <summary>
        /// Reads the JSON returned from the website and converts it into an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="httpClient">The http client used for the request</param>
        /// <param name="requestUri">The Uri the request is sent to/></param>
        /// <returns></returns>
        public static async Task<T> GetJsonObjectAsync<T>(this HttpClient httpClient, Uri requestUri)
        {
            return JsonSerializer.Deserialize<T>(await httpClient.GetStringAsync(requestUri));
        }
    }
}