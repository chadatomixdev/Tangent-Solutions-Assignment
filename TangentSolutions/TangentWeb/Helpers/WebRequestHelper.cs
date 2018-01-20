using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TangentWeb.Helpers
{
    public static class WebRequestHelper
    {
        public static string BaseUrl => "http://staging.tangent.tngnt.co/";

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

        //public static async Task<string> MakeAsyncRequest(string url)
        //{
        //    var httpClient = new HttpClient { Timeout = new TimeSpan(0, 5, 0) };
        //    var contentsTask = httpClient.GetStringAsync(url);

        //    var contents = await contentsTask;

        //    return contents;
        //}

        //public static async Task<string> MakeAsyncRequest(string url, string token)
        //{
        //    var httpClient = new HttpClient { Timeout = new TimeSpan(0, 5, 0) };
        //    var contentsTask = httpClient.GetStringAsync(url);

        //    var contents = await contentsTask;

        //    return contents;
        //}
    }
}
