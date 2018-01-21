using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TangentWeb.Helpers
{
    public static class WebRequestHelper
    {
        public static string BaseUrl => "http://staging.tangent.tngnt.co/";

        /// <summary>
        /// Post Async No Token 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> MakeAsyncRequest(string url, Dictionary<string, string> content)
        {
            var httpClient = new HttpClient
            {
                Timeout = new TimeSpan(0, 5, 0),
                BaseAddress = new Uri(url)
            };

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type: application/x-www-form-urlencoded", "application/json");

            if (content == null)
            {
                content = new Dictionary<string, string>();
            }

            var encodedContent = new FormUrlEncodedContent(content);

            return await httpClient.PostAsync(httpClient.BaseAddress, encodedContent); ;
        }

        /// <summary>
        /// Get Async Token Based 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> MakeAsyncRequest(string url, string token)
        {
            var httpClient = new HttpClient
            {
                Timeout = new TimeSpan(0, 5, 0),
                BaseAddress = new Uri(url)
            };

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type: application/x-www-form-urlencoded", "application/json");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);

            return await httpClient.GetAsync(httpClient.BaseAddress); ;
        }

        /// <summary>
        /// Post Async Token Based
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public static async Task<HttpResponseMessage> MakeAsyncRequest(string url, Dictionary<string, string> content, string token)
        {
            var httpClient = new HttpClient
            {
                Timeout = new TimeSpan(0, 5, 0),
                BaseAddress = new Uri(url)
            };

            httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type: application/x-www-form-urlencoded", "application/json");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Token", token);

            if (content == null)
            {
                content = new Dictionary<string, string>();
            }

            var encodedContent = new FormUrlEncodedContent(content);

            return await httpClient.PostAsync(httpClient.BaseAddress, encodedContent); ;
        }
    }
}
